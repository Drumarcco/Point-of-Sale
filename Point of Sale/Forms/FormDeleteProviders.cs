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
    public partial class FormDeleteProviders : Form
    {
        public FormDeleteProviders()
        {
            InitializeComponent();
        }

        private void FormDeleteProviders_Load(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(DBConnect.ConnectionString);
            try
            {
                connection.Open();

                MySqlCommand cmd = new MySqlCommand("delete_provider", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                int anInteger;
                anInteger = Convert.ToInt32(txt_ID.Text);
                cmd.Parameters.AddWithValue("@ident", anInteger);

                cmd.ExecuteNonQuery();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_ID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_delete_Click(null, null);
            }
            if (e.KeyCode == Keys.Escape)
            {
                btn_cancel_Click(null, null);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
