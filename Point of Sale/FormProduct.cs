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
    public partial class FormProduct : Form
    {
        private Product _product;
        public FormProduct()
        {
            InitializeComponent();
            _product = new Product();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(DBConnect.ConnectionString);
            try
            {
                connection.Open();
                saveProduct();

                MySqlCommand cmd = new MySqlCommand("insert_product", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", _product.Name);
                cmd.Parameters.AddWithValue("@Category", _product.Category);
                cmd.Parameters.AddWithValue("@Cost", _product.Cost);
                cmd.Parameters.AddWithValue("@Price", _product.Price);
                cmd.Parameters.AddWithValue("@DiscountPercent", 0);
                cmd.Parameters.AddWithValue("@Provider", _product.Provider);

                cmd.ExecuteNonQuery();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveProduct()
        {
            _product.Name = txt_name.Text;
            _product.Provider = (int) cbx_provider.SelectedValue;
            _product.Category = cbx_category.SelectedText;
            _product.Cost = float.Parse(txt_cost.Text);
            _product.Price = float.Parse(txt_price.Text);
        }



        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_point_of_saleDataSet1.category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Connection.ConnectionString = DBConnect.ConnectionString;
            this.categoryTableAdapter.Fill(this._point_of_saleDataSet1.category);
            // TODO: This line of code loads data into the '_point_of_saleDataSet1.provider' table. You can move, or remove it, as needed.
            this.providerTableAdapter1.Connection.ConnectionString = DBConnect.ConnectionString;
            this.providerTableAdapter1.Fill(this._point_of_saleDataSet1.provider);

        }
    }
}
