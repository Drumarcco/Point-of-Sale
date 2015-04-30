using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Point_of_Sale
{
    public static class DBConnect
    {
        public static string ConnectionString { get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; }

        public static void Initialize()
        {
            ConnectionString = Properties.Settings.Default.point_of_saleConnectionString;
            ConnectionString += ";Uid=" + Username + ";";
            ConnectionString += "Pwd=" + Password + ";";
           
        }

    }
}
