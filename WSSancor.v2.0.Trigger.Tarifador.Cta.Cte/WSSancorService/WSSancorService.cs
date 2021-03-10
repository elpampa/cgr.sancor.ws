using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.ServiceModel.Security;
using System.ServiceProcess;
using System.Timers;
using log4net;
using log4net.Config;

namespace WSSancorService
{
    public partial class WSSancorService : ServiceBase
    {
        private static string connectionString;
        private static ILog log;
        private readonly Timer timer = new Timer();

        public WSSancorService()
        {
            InitializeComponent();
        }

        private void TimerOnElapsed(object sender, ElapsedEventArgs elapsedEventArgs)
        {
            timer.Stop();

            try
            {
                refreshData();
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                throw;
            }
            finally
            {
                timer.Start();
            }

        }

        protected override void OnStart(string[] args)
        {
            connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            var logDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            XmlConfigurator.Configure(new FileInfo(logDirectory + @"\_config\log4net\" + ConfigurationManager.AppSettings["LogFilePath"]));

            log = LogManager.GetLogger("LogFile");
            log.Info("Inicio Proceso");

            timer.Interval = Int32.Parse(ConfigurationManager.AppSettings["Pool.Timeout"]);
            timer.Elapsed += TimerOnElapsed;
            timer.Start();
        }

        protected override void OnStop()
        {
            timer.Stop();
            log.Info("Fin Proceso");
        }


        private void refreshData()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var command = new SqlCommand(
                @"Select ncContratoCtaCteRequest, nContrato, cResultado, cError, cdError, dGeneracionResultado, dDateIns, cUserIns, cReferencia From dbo.WSSancorCtaCteRequest where ncEstado = 2 ORDER BY ncContratoCtaCteRequest ASC",
                connection);

                DbDataAdapter adapter = new SqlDataAdapter(command);
                var dataSet = new DataSet();
                var filled = adapter.Fill(dataSet);

                foreach (DataRow dr in dataSet.Tables[0].Rows)
                {
                    var cError = "";
                    var cdError = "";
                    var cResultado = string.Empty;
                    var id = Convert.ToInt32(dr["ncContratoCtaCteRequest"]);
                    var contrato = Convert.ToInt32(dr["nContrato"]);

                    try
                    {
                       cResultado = WSSancor.CuentaCorriente.EstadoCuenta(contrato);
                    }
                    catch (SecurityNegotiationException exception)
                    {
                        throw new Exception(exception.Message);
                    }
                    catch (Exception exception)
                    {
                        cError = "ERROR";
                        cResultado = "";
                        cdError = exception.Message.Replace("'", "''");
                    }
                    finally
                    {
                        using (var connection2 = new SqlConnection(connectionString))
                        {
                            connection2.Open();
                            var command2 = new SqlCommand(
                              @"UPDATE dbo.WSSancorCtaCteRequest
                                SET cResultado = '" +  cResultado.Replace("'", "''") + @"',
                                    dGeneracionResultado = GETDATE(),
                                    cError = '" + cError + @"',
                                    cdError = '" + cdError + @"',
                                    ncEstado = 3
                                FROM dbo.WSSancorCtaCteRequest 
                                WHERE ncContratoCtaCteRequest = " + id, connection2);

                            command2.ExecuteNonQuery();
                        }

                        if (cError == "")
                        {
                            log.Info("PROCESO REGISTRO ID NRO: " + id + ", CONTRATO:" + contrato);
                        }
                        else
                        {
                            log.Error("PROCESO REGISTRO ID NRO: " + id + ", CONTRATO:" + contrato + " - ERROR: " + cdError);
                        }
                    }
                }
            }
        }
    }
}
