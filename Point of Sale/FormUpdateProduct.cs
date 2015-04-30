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
    public partial class FormUpdateProduct : Form
    {
        private FormProduct frmproduct;
        private MySqlDataAdapter da;        // Data Adapter
        private DataSet ds;                 // Dataset
        private string sTable = "product";  // Table Name

        public FormUpdateProduct()
        {
            InitializeComponent();
            
        }

        private void FormUpdateProduct_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_point_of_saleDataSet.product' Puede moverla o quitarla según sea necesario.
    //        this.productTableAdapter.Fill(this._point_of_saleDataSet.product);
            updateData();
        }

        private void product_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String ID = product_table.CurrentRow.Cells[0].Value.ToString();
            frmproduct = new FormProduct(int.Parse(ID));

            if (frmproduct.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                updateData();
            }
        }

        private void updateData()
        {
            MySqlConnection connection = new MySqlConnection(DBConnect.ConnectionString);
   
            try 
	            {
	            connection.Open();
                da = new MySqlDataAdapter("SELECT * FROM product;", connection);
                ds = new DataSet();
                da.Fill(ds, sTable);
                connection.Close();
	            }

	        catch (MySql.Data.MySqlClient.MySqlException ex)
	           {
                MessageBox.Show(ex.Message);
                connection.Close();
	            }
            
            finally 
            {
                product_table.Refresh();
                product_table.DataSource = ds;
                product_table.DataMember = sTable;
            }
        }

        private void product_table_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String ID = product_table.CurrentRow.Cells[0].Value.ToString();
            MessageBox.Show(ID);
            frmproduct = new FormProduct(int.Parse(ID));
            frmproduct.ShowDialog();

            if (frmproduct.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                updateData();
            }

        } 
    }
}
