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
    public partial class FormProviders : Form
    {
        private Provider _provider;
        public FormProviders()
        {
            InitializeComponent();
            _provider = new Provider();
        }

        private void FormProviders_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(DBConnect.ConnectionString);
            try
            {
                connection.Open();
                saveProvider();

                MySqlCommand cmd = new MySqlCommand("insert_provider", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", _provider.Name);
                cmd.Parameters.AddWithValue("@Address", _provider.Address);
                cmd.Parameters.AddWithValue("@Cellphone", _provider.Cellphone);
                cmd.Parameters.AddWithValue("@Phone", _provider.Phone);

                cmd.ExecuteNonQuery();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveProvider()
        {
            _provider.Name = txt_Name.Text;
            _provider.Address = txt_Address.Text;
            _provider.Cellphone = txt_Cell.Text;
            _provider.Phone = txt_Phone.Text;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Phone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_save_Click(null, null);
            }
        }

        private void txt_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
