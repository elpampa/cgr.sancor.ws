using System;
using System.Configuration;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using Microsoft.SqlServer.Server;
using WSSancor.WSTarifas;

namespace WSSancor
{
    public static class Tarifas
    {
        public static X509Certificate FindCertificate(StoreLocation location, StoreName name, X509FindType findType, string findValue)
        {
            var store = new X509Store(name, location);

            try
            {
                store.Open(OpenFlags.ReadOnly);
                var col = store.Certificates.Find(findType, findValue, true);
                return col[0];
            }
            finally
            {
                store.Close();
            }
        }

        [SqlProcedure]
        public static string RecuperarProvincias()
        {
            var proxyTarifas = new ProxyTarifas();

            var x509Certificate = FindCertificate(StoreLocation.LocalMachine, StoreName.My, X509FindType.FindBySubjectName, "usrConsulGroup");
            proxyTarifas.ClientCertificates.Add(x509Certificate);
            ProvinciaRiesgo[] provinciaRiesgos = proxyTarifas.RecuperarProvincias();

            string result = string.Empty;

            foreach (var provinciaRiesgo in provinciaRiesgos)
            {
                   result += provinciaRiesgo.NombrePcia + ",";
            }

            return result;
        }

        [SqlProcedure]
        public static string CotizarPMX(long cuitEmpresa, 
                                        string razonSocial,
                                        int codActividad,
                                        int cantTrabajadores,
                                        decimal masaSalarial,
                                        byte codProvinciaRiesgo,
                                        byte codModuloRC,
                                        byte codModuloAP)
        {
            var proxyTarifas = new ProxyTarifas();
            var x509Certificate = FindCertificate(StoreLocation.LocalMachine, StoreName.My, X509FindType.FindBySubjectName, "usrConsulGroup");

            proxyTarifas.ClientCertificates.Add(x509Certificate);
            CotizacionGSS cotizacionGss = proxyTarifas.TarifarPMX(cuitEmpresa, razonSocial, codActividad,
                                                                  cantTrabajadores, masaSalarial, codProvinciaRiesgo,
                                                                  codModuloRC, codModuloAP);
            return cotizacionGss.ToString();
        }

        [SqlProcedure]
        public static string CotizarART(long cuitEmpresa,
                                      int codActividad,
                                      int cantTrabajadores,
                                      decimal masaSalarial,
                                      short codPostal)
        {
            var proxyTarifas = new ProxyTarifas();

            var x509Certificate = FindCertificate(StoreLocation.LocalMachine, StoreName.My, X509FindType.FindBySubjectName, "usrConsulGroup");

            proxyTarifas.ClientCertificates.Add(x509Certificate);
            Alicuota alicuota = proxyTarifas.TarifarART(cuitEmpresa, codActividad, cantTrabajadores, masaSalarial, codPostal);
         
            return @"<CRESULTADO><NIALICUOTAFIJA>" + alicuota.MontoFijo.ToString().Replace(",", ".") + @"</NIALICUOTAFIJA><NPALICUOTAPORCENTUAL>" + alicuota.PorcVariable.ToString().Replace(",", ".") + @"</NPALICUOTAPORCENTUAL><CCOMENTARIO>" + alicuota.Descripcion + @"</CCOMENTARIO></CRESULTADO>";
        }
    
    }
}
