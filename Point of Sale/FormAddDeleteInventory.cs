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
    public partial class FormAddDeleteInventory : Form
    {
        private Inventory _inventory;

        public FormAddDeleteInventory()
        {
            InitializeComponent();
        }
        public FormAddDeleteInventory(int Id, String nameProduct, bool addordelete) 
        {
            InitializeComponent();
            _inventory = new Inventory(Id,nameProduct,addordelete);
            setValues();
            if (_inventory.addordelete == false)
            {
                btn_save.Text = "Eliminar";
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (_inventory.addordelete == true)
            {
                MySqlConnection connection = new MySqlConnection(DBConnect.ConnectionString);
                try
                {
                    connection.Open();
                    saveProduct();

                    MySqlCommand cmd = new MySqlCommand("insert_receipt", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Product", _inventory.Id);
                    cmd.Parameters.AddWithValue("@Quantity", _inventory.quantity);

                    cmd.ExecuteNonQuery();
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else 
            {
                MySqlConnection connection = new MySqlConnection(DBConnect.ConnectionString);
                try
                {
                    connection.Open();
                    saveProduct();

                    MySqlCommand cmd = new MySqlCommand("delete_issues", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Product", _inventory.Id);

                    cmd.ExecuteNonQuery();
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void saveProduct(){
            _inventory.quantity = float.Parse(txb_quantity.Text);
        }

        public void setValues(){
            txb_nameProduct.Text = _inventory.nameProduct;
        }
    }
}
