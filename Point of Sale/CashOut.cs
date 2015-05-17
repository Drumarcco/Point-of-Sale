using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Point_of_Sale
{
    class CashOut
    {

        public CashOut() {
            generateReport();
        }
        private async Task generateReport() {
            var report = await Program.JSReportServer.ReportingService.RenderAsync("7kNUnVqA", "{\"day\" : 16,\"month\" : \"Mayo\",\"year\" : 2015,\"cashier\" : \"Marco Alvarado Mazon\",\"sale\" : [{\"product\": \"Coca-Cola 600ML\", \"quantity\": 20, \"total\": 2000 }]}");
            using (var fileStream = File.Create("C:\\temp\\report.pdf")) {
                report.Content.CopyTo(fileStream);
            }                       
        }
    }
}
