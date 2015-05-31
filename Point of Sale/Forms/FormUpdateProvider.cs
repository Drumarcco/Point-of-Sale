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
    public partial class FormUpdateProvider : Form
    {
        private FormProviders frmprovider;
        private MySqlDataAdapter dataAdapter;        // Data Adapter
        private DataSet dataSet;                 // Dataset
        private string sTable = "provider";  // Table Name

        public FormUpdateProvider()
        {
            InitializeComponent();
        }

        private void FormUpdateProvider_Load(object sender, EventArgs e)
        { 
            updateData();
        }

        private void provider_table_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        } 

        private void updateData()
        {
            MySqlConnection connection = new MySqlConnection(DBConnect.ConnectionString);

            try
            {
                connection.Open();
                dataAdapter = new MySqlDataAdapter("SELECT * FROM provider;", connection);
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet, sTable);
                connection.Close();
            }

            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }

            finally
            {
                provider_table.Refresh();
                provider_table.DataSource = dataSet;
                provider_table.DataMember = sTable;
            }
        }

        private void provider_table_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String ID = provider_table.CurrentRow.Cells[0].Value.ToString();
            frmprovider = new FormProviders(int.Parse(ID));
            frmprovider.ShowDialog();

            if (frmprovider.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                updateData();
            }

        }
    }
}
