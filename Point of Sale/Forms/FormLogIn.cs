using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Point_of_Sale
{
    public partial class FormLogIn : Form
    {
        public String savedUser;
        public FormLogIn()
        {
            InitializeComponent();
         
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            savedUser = DBConnect.Username;
            DBConnect.Username = txt_user.Text;
            DBConnect.Password = txt_password.Text;
            DBConnect.Initialize();
            
            MySqlConnection connection = new MySqlConnection(DBConnect.ConnectionString);
            try
            {
                connection.Open();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Usuario o contraseña incorrecto(s).");
            }

        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Enter: btn_login_Click(null, null);
                    break;
                default: break;
            }
        }
    }
}
