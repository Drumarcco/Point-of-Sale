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
    public partial class DialogProductSearch : Form
    {
        public int productId { get; private set; }
        private String query;
        
        public DialogProductSearch(String query)
        {
            InitializeComponent();
            this.query = query;
        }
        private void DialogProductSearch_Load(object sender, EventArgs e)
        {
            fillProductListBox();            
        }

        private void fillProductListBox() {
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(DBConnect.ConnectionString);
                connection.Open();
                MySqlCommand command = new MySqlCommand("SELECT id, name FROM product WHERE name LIKE @query", connection);
                command.Parameters.AddWithValue("@query", "%" + query + "%");
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                DataTable productTable = new DataTable();
                dataAdapter.Fill(productTable);

                lbx_productMatches.DataSource = productTable;
                lbx_productMatches.DisplayMember = "Name";
                lbx_productMatches.ValueMember = "ID";

                if (lbx_productMatches.Items.Count == 0)
                {
                    throw new ArgumentException("No se encontraron productos con ese nombre.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentException argEx) {
                MessageBox.Show(argEx.Message);
                this.Close();
            }
            finally
            {
                if (connection != null) connection.Close();
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (lbx_productMatches.SelectedItem != null) {
                this.productId = (int) lbx_productMatches.SelectedValue;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void lbx_productMatches_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                btn_OK_Click(null, null);
            }
            if (e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }
    }
}
