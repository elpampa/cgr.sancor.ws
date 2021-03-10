using System;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using CuentaCorriente.ARTServices;
using Microsoft.SqlServer.Server;
using Microsoft.Win32;

namespace WSSancor
{
    public static class CuentaCorriente
    {
        public static string EstadoCuenta(int contrato)
        {
            var client = new ARTServicesClient();
            
         //   client.ClientCredentials.ClientCertificate.SetCertificate(StoreLocation.LocalMachine, StoreName.My, X509FindType.FindBySubjectName, "usrConsulGroup");

            var req = new ObtenerCtaCteContratosRequest { Contrato = contrato };
            var resp = new ObtenerCtaCteContratosResponse();


            try
            {
                resp = client.ObtenerCteCteContratos(req);
            }
            catch (Exception ex)
            {
                throw;
            }
            

            var header = "<FECHA>" + resp.CtaCteContratos.FECHA + "</FECHA><CUIT>" + resp.CtaCteContratos.CUIT + "</CUIT><RAZOC>" +
                            resp.CtaCteContratos.RAZSOC + "</RAZOC><ALTA>" + resp.CtaCteContratos.ALTA + "</ALTA>" + 
                            "<CONTR>" + resp.CtaCteContratos.CONTR + "</CONTR>" +
                            "<FECHALTA>" + resp.CtaCteContratos.FECHALTA + "</FECHALTA><BAJA>" + resp.CtaCteContratos.BAJA +
                            "</BAJA>" +
                            "<FECHBAJA>" + resp.CtaCteContratos.FECHBAJA + "</FECHBAJA><TELEF>" +
                            resp.CtaCteContratos.TELEF + "</TELEF>" +
                            "<MAIL>" + resp.CtaCteContratos.MAIL + "</MAIL><SALDOF>" + resp.CtaCteContratos.SALDOF +
                            "</SALDOF>" +
                            "<ADVERTENCIA>" + resp.CtaCteContratos.ADVERTENCIA + "</ADVERTENCIA>";

            var details = "<DETALLES>";

            foreach (var detalle in resp.CtaCteContratos.DETALLE)
            {
                details += "<DETALLE><MES>" + detalle.MES + "</MES><MESDGI>" + detalle.MESDGI + "</MESDGI>" +
                            "<EMPL>" + detalle.EMPL + "</EMPL><MASA>" + detalle.MASA + "</MASA>" +
                            "<FUOEMIT>" + detalle.FUOEMIT + "</FUOEMIT><ALIEMIT>" + detalle.ALIEMIT + "</ALIEMIT>" +
                            "<FIJODECL>" + detalle.FIJODECL + "</FIJODECL><ALIDECL>" + detalle.ALIDECL + "</ALIDECL>" +
                            "<CUOTA>" + detalle.CUOTA + "</CUOTA><FFE>" + detalle.FFE + "</FFE>" +
                            "<PAGOCUOTA>" + detalle.PAGOCUOTA + "</PAGOCUOTA><PAGOFFE>" + detalle.PAGOFFE + "</PAGOFFE>" +
                            "<INTFINCO>" + detalle.INTFINCO + "</INTFINCO><INTMORA>" + detalle.INTMORA + "</INTMORA>" +
                            "<SALDOMES>" + detalle.SALDOMES + "</SALDOMES></DETALLE>";
            }

            details += "</DETALLES>";

            return @"<CRESULTADO>" + header + details + "</CRESULTADO>";
        }
    }
}
