//using QuotationServiceTester.QuotationService;
using System;
using System.IO;

namespace QuotationServiceTester
{
    class Program
    {
        static void Main(string[] args)
        {
            QuotationService.QuotationServiceClient qClient = new QuotationService.QuotationServiceClient();

            var fechas = new DateTime[] { };

            // Cotización Individual - Mínima.
            var req = new QuotationService.CreateIndividualQuotationFullRequest()
            {
                LocalityID = 3100,
                Obligatory = false,
                ProducerID = 211360,
                Sons = 0,
                Dependents = fechas,
                UnifiesContributions = false,
                Holder = new QuotationService.Holder()
                {
                    BirthDate = new DateTime(1960, 03, 08),
                    DocumentType = 5,
                    FirstName = "Juana",
                    LastName = "Saucedo",
                    TributaryCode = 27165498963,
                    Email = "jS@kinexo.com",
                    Telephone = new QuotationService.TelephoneContact()
                    {
                        AreaCode = "444",
                        PhoneNumber = 444555666
                    }
                }
            };


            var resp = qClient.CreateIndividualQuotationFull(req);

            var req2 = new QuotationService.SaveSelectedPlansFullRequest
            {
                PlandIds = new string[] { "A1", "A2" },
                QuotationID = resp.QuotationID
            };

            var result = qClient.SaveSelectedPlansFull(req2);

            string fileNameAndExt = string.Format("IndQuot_{0}_{1}.pdf", resp.QuotationID, DateTime.Now.ToString("hhmmss")); //Path

            SaveInDisk(result.Quotation.Report, fileNameAndExt);
        }

        private static void SaveInDisk(byte[] report, string fileNameAndExt)
        {
            var resultFileName = Path.Combine(@"D:\Temp", fileNameAndExt);

            var memoryStream = new MemoryStream(report);

            memoryStream.Position = 0;

            // Guardar en carpeta.
            using (var fileStream = new FileStream(resultFileName, FileMode.Create, FileAccess.Write))
            {
                memoryStream.CopyTo(fileStream);
            }

            memoryStream.Close();
        }
    }
}
 