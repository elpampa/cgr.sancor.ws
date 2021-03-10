using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotationServiceTester
{
    class Program
    {
        static void Main(string[] args)
        {
            QuotationService.QuotationServiceClient qClient = new QuotationService.QuotationServiceClient();

            //var r1 = qClient.GetQuotationPlansPricesReport(new QuotationService.GetQuotationPlansPricesReportRequest()
            //{
            //    IsHealthPromoter = false,
            //    IsIndividual = true,
            //    LocalityId = 2090
            //});

            //var r2 = qClient.SaveSelectedPlansFull(new QuotationService.SaveSelectedPlansFullRequest()
            //{
            //    PlandIds = new string[] { "A1", "A2" },
            //    QuotationID = 123
            //});

            var fechas = new DateTime[] {};

            var req = new QuotationService.CreateIndividualQuotationFullRequest()
                {
                    LocalityID = 3100,
                    Obligatory = false,
                    ProducerID = 211360,
                    Sons = 3,
                    Dependents = fechas,
                    UnifiesContributions = false,
                    Spouse = new QuotationService.Person()
                        {
                            BirthDate = new DateTime(1941, 11, 18),
                            DocumentNumber = 3956861,
                            DocumentType = 5,
                            FirstName = "MARIA TERESITA",
                            LastName = "BIANCHINI",
                            TributaryCode = 27039568611
                        },
                    Holder = new QuotationService.Holder()
                        {
                            BirthDate = new DateTime(1939, 09, 29),
                            DocumentNumber = 5934555,
                            DocumentType = 1,
                            FirstName = "MIGUEL CESAR",
                            LastName = "GIECO",
                            TributaryCode = 23059345559,
                            Email = "miguelgieco@kinexo.com",
                            Telephone = new QuotationService.TelephoneContact()
                                {
                                    AreaCode = "343",
                                    PhoneNumber = 156201201
                                }
                        }
                };


            var resp = qClient.CreateIndividualQuotationFull(req);
            

//            var request = "<?xml version="1.0" encoding="UTF-8"?>
//<soapenv:Envelope xmlns:soapenv="http://schemas.xmlsoap.org/soap/envelope/" xmlns:tem="http://tempuri.org/" xmlns:prev="http://schemas.datacontract.org/2004/07/PrevencionSalud.Services.Contract.Quotation" xmlns:arr="http://schemas.microsoft.com/2003/10/Serialization/Arrays">
//   <soapenv:Header/>
//   <soapenv:Body>
//      <tem:CreateIndividualQuotationFull>
//         <!--Optional:-->
//         <tem:request>
//            <prev:Dependents>
//            </prev:Dependents>
//            <prev:Holder>
//               <prev:BirthDate>1939-09-29T00:00:00</prev:BirthDate>
//               <prev:DocumentNumber>5934555</prev:DocumentNumber>
//               <prev:DocumentType>1</prev:DocumentType>
//               <prev:FirstName>MIGUEL CESAR</prev:FirstName>
//               <prev:LastName>GIECO</prev:LastName>
//               <prev:TributaryCode>23059345559</prev:TributaryCode>
//               <prev:Email>miguelgieco@kinexo.com</prev:Email>
//               <prev:Telephone>
//                  <prev:AreaCode>343</prev:AreaCode>
//                  <prev:PhoneNumber>156201201</prev:PhoneNumber>
//               </prev:Telephone>
//            </prev:Holder>
//            <prev:LocalityID>3100</prev:LocalityID>
//            <prev:Obligatory>false</prev:Obligatory>
//            <prev:ProducerID>211360</prev:ProducerID>
//            <prev:Sons>3</prev:Sons>
//            <prev:Spouse>
//               <prev:BirthDate>1941-01-18T00:00:00</prev:BirthDate>
//               <prev:DocumentNumber>3956861</prev:DocumentNumber>
//               <prev:DocumentType>5</prev:DocumentType>
//               <prev:FirstName>MARIA TERESITA</prev:FirstName>
//               <prev:LastName>BIANCHINI</prev:LastName>
//               <prev:TributaryCode>27039568611</prev:TributaryCode>
//            </prev:Spouse>
//            <prev:UnifiesContributions>false</prev:UnifiesContributions>
//         </tem:request>
//      </tem:CreateIndividualQuotationFull>
//   </soapenv:Body>
//</soapenv:Envelope>""
        }
    }
}
