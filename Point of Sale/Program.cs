using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_of_Sale
{
    static class Program
    {
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
                Application.Run(new FormHome(user));
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
