using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using jsreport.Embedded;

namespace Point_of_Sale
{
    static class Program
    {
        public static EmbeddedReportingServer JSReportServer = new EmbeddedReportingServer(port: 2000);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormLogIn login = new FormLogIn();
            DialogResult result = login.ShowDialog();
            String user = login.savedUser;
            if (result == DialogResult.OK)
            {
                startJSReportServer();
                Application.Run(new FormHome(user));
                stopJSReportServer();
            }
            else
            {
                Application.Exit();
            }
        }

        static async Task startJSReportServer() { 
            await JSReportServer.StartAsync();
            Console.Write("JSReport Server started");
        }

        static async Task stopJSReportServer() {
            await JSReportServer.StopAsync();
        }
    }
}
