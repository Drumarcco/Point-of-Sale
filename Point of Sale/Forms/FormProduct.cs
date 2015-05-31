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
        private bool productexist = false;
        
        public FormProduct()
        {
            InitializeComponent();
            _product = new Product();
        }
        public FormProduct(int ID)
        {
            InitializeComponent();
            _product = new Product(ID);
            productexist = true;
            setValues();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(DBConnect.ConnectionString);
            try
            {
                connection.Open();
                saveProduct();

                if (productexist == false)
                {
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

                else
                {
                    MySqlCommand cmd = new MySqlCommand("alter_product", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@_Name", _product.Name);
                    cmd.Parameters.AddWithValue("@_ID", _product.Id);
                    cmd.Parameters.AddWithValue("@_Category", _product.Category);
                    cmd.Parameters.AddWithValue("@_Cost", _product.Cost);
                    cmd.Parameters.AddWithValue("@_Price", _product.Price);
                    cmd.Parameters.AddWithValue("@_DiscountPercent", 0);
                    cmd.Parameters.AddWithValue("@_Provider", _product.Provider);

                    cmd.ExecuteNonQuery();
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();

                }

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
            _product.Category = (int) cbx_category.SelectedValue;
            _product.Cost = float.Parse(txt_cost.Text);
            _product.Price = float.Parse(txt_price.Text);
        }

        private void setValues()
        {
            
            txt_name.Text = _product.Name;
            cbx_provider.SelectedValue = _product.Provider;
            cbx_category.SelectedValue = _product.Category;
            txt_cost.Text = _product.Cost.ToString();
            txt_price.Text = _product.Price.ToString();
        }



        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            this.providerTableAdapter1.Fill(this._point_of_saleDataSet1.provider);
            this.categoryTableAdapter.Connection.ConnectionString = DBConnect.ConnectionString;
            this.categoryTableAdapter.Fill(this._point_of_saleDataSet1.category);
        }

        private void txt_price_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_save_Click(null, null);
            }
        }
    }
}
