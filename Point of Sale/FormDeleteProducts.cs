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
    public partial class FormDeleteProducts : Form
    {
        public FormDeleteProducts()
        {
            InitializeComponent();
        }

        private void FormDeleteProducts_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(DBConnect.ConnectionString);
            try
            {
                connection.Open();

                MySqlCommand cmd = new MySqlCommand("delete_product", connection);
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

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
