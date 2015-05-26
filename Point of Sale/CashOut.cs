using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Point_of_Sale
{
    class CashOut
    {

        public CashOut() {
            generateReport();
        }
        private async Task generateReport() {
            String day = DateTime.Now.Day.ToString();
            String month = DateTime.Now.ToString("MMMM");
            String year = DateTime.Now.Year.ToString();
            String cashier = DBConnect.Username;

            String reportTemplate = "{{ \"day\" : {0}, \"month\" : \"{1}\", \"year\" : {2}, \"cashier\" : \"{3}\", \"sale\" : [ ";
            reportTemplate = String.Format(reportTemplate, day, month, year, cashier);
            reportTemplate += getReportData() + "] }";

            try {
                var report = await Program.JSReportServer.ReportingService.RenderAsync("Q1RB2D81e", reportTemplate);
                String filePath = "C:\\temp\\report.pdf";
                using (var fileStream = File.Create(filePath))
                {
                    report.Content.CopyTo(fileStream);
                    System.Diagnostics.Process.Start(@filePath);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
                                   
        }

        private String getReportData() {
            MySqlConnection conn = new MySqlConnection(DBConnect.ConnectionString);
            try {
                MySqlCommand command = new MySqlCommand("cashout", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                String data = "";
                String template = "{{ \"product\": \"{0}\", \"quantity\": {1}, \"total\": {2} }}";
                
                foreach (DataRow row in table.Rows)
                {
                    String product = row.ItemArray[0].ToString();
                    String quantity = row.ItemArray[1].ToString();
                    String total = row.ItemArray[2].ToString();

                    String stringRow = String.Format(template, product, quantity, total) + ",";
                    data += stringRow;
                }
                data = data.Remove(data.Length - 1);
                return data;             
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
            catch (FormatException fex)
            {
                MessageBox.Show(fex.Message);
                return "";
            }
            finally
            {
                if (conn != null) conn.Close();
            }
        }


    }
}
