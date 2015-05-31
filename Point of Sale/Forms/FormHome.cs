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
    public partial class FormHome : Form
    {
        private BindingList<Lot> productList;
        private float subtotal;
        private float tax;
        private float total;
        private bool saleIsActive;
        string keepUser;

        public FormHome(string printUser)
        {
            keepUser = printUser;
            InitializeComponent();
            showLoggedUser();
            newSale();
            System.Diagnostics.Process.Start("http://www.chartjs.org/");
            
        }

        private void setSubtotal()
        {
            float subtotal = 0;
            foreach (Lot lot in productList) {
                subtotal += lot.Product.getRealPrice() * lot.Quantity;
            }
            this.subtotal = subtotal;
        }

        private void setTax(float subtotal) {
            this.tax = (float)(subtotal * 0.16);
        }

        private void setTotal(float subtotal, float tax) {
            this.total = subtotal + tax;
        }

        private void updateSaleValues() {
            setSubtotal();
            setTax(subtotal);
            setTotal(subtotal, tax);
            lbl_subtotal.Text = subtotal.ToString("C2");
            lbl_tax.Text = tax.ToString("C2");
            lbl_total.Text = total.ToString("C2");
        }


        private void txt_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                showQuantityChanger();
            }
            if (e.KeyCode == Keys.Enter) {
                if (!saleIsActive) {
                    newSale();
                }
                int productID;
                if (! int.TryParse(txt_Search.Text, out productID))
                {
                    if (isSaleReadyToEnd())
                    {
                        endSale();
                        return;
                    }
                    else {
                        DialogProductSearch productSearch = new DialogProductSearch(txt_Search.Text);
                        productSearch.ShowDialog();
                        if (productSearch.DialogResult == DialogResult.OK)
                        {
                            productID = productSearch.productId;
                        }
                        else
                        {
                            txt_Search.Clear();
                            return;
                        }
                    }
                }
                addProductToList(productID);
                txt_Search.Clear();
            }
        }

        private bool isSaleReadyToEnd() {
            return txt_Search.Text.Trim() == "" && productList.Count > 0;
        }

        private void showQuantityChanger() {
            ProductQty frmQty = new ProductQty();
            frmQty.ShowDialog();

            if (frmQty.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                float quantity = frmQty.quantity;
                setProductQuantity(quantity);
                updateProductListTable();
                updateSaleValues();
            }
        }

        private void newSale() {
            productList = new BindingList<Lot>();
            subtotal = 0;
            tax = 0;
            total = 0;
            saleIsActive = true;
            resetLabels();
        }

        private void resetLabels() {
            lbl_change.Text = "-";
            lbl_received.Text = "-";
            lbl_subtotal.Text = "-";
            lbl_tax.Text = "-";
            lbl_total.Text = "-";
        }

        private void endSale() {
            FormPayment formPayment = new FormPayment(this.total);
            formPayment.ShowDialog();
            if (formPayment.DialogResult == System.Windows.Forms.DialogResult.OK) {
                float receivedMoney = formPayment.received;
                lbl_received.Text = receivedMoney.ToString("C2");
                updateChange(formPayment.received);
                saleIsActive = false;

                registerSaleOnDatabase();
            }
        }

        private void registerSaleOnDatabase() {
            MySqlConnection connection = new MySqlConnection(DBConnect.ConnectionString);
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("insert_sale", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Subtotal", this.subtotal);
                command.ExecuteNonQuery();

                int saleID = 0;
                command = new MySqlCommand("SELECT LAST_INSERT_ID()", connection);
                command.CommandType = CommandType.Text;
                saleID = Convert.ToInt32(command.ExecuteScalar());

                command = new MySqlCommand("insert_product_sale", connection);
                command.CommandType = CommandType.StoredProcedure;
                foreach (Lot lot in productList)
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@Product", lot.Product.Id);
                    command.Parameters.AddWithValue("@Sale", saleID);
                    command.Parameters.AddWithValue("@Quantity", lot.Quantity);
                    command.Parameters.AddWithValue("@CurrentPrice", lot.Product.getRealPrice());
                    command.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                if (connection != null) {
                    connection.Close();
                }
            }
        }

        private void updateChange(float received) {
            float change = received - total;
            lbl_change.Text = change.ToString("C2");
        }

        private void addProductToList(int productID) {
            try
            {
                Product product = new Product(productID);
                if (isProductOnList(product))
                {
                    int lotIndex = getLotIndexFromList(product);
                    Lot lot = productList[lotIndex];
                    lot.Quantity++;
                    productList[lotIndex] = lot;
                }
                else
                {
                    Lot lot = new Lot(product, 1);
                    productList.Add(lot);
                }
                updateProductListTable();
                updateSaleValues();
            }
            catch (ArgumentException argEx) {
                MessageBox.Show(argEx.Message);
            }
            
        }

        private bool isProductOnList(Product product) {
            foreach (Lot lot in productList) {
                if (lot.Product.Id == product.Id) return true;
            }
            return false;
        }

        private int getLotIndexFromList(Product product) { 
            int i = 0;
            foreach (Lot lot in productList) {
                if (lot.Product.Id == product.Id)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }

        private void updateProductListTable() {
            dag_productTable.Rows.Clear();
            foreach (Lot lot in productList) {
                DataGridViewRow row = (DataGridViewRow)dag_productTable.Rows[0].Clone();
                row.Cells[1].Value = lot.Product.Name;
                row.Cells[2].Value = lot.Quantity;
                row.Cells[3].Value = lot.Product.getRealPrice();
                row.Cells[4].Value = lot.Product.getDiscount();
                row.Cells[5].Value = lot.Subtotal;
                dag_productTable.Rows.Add(row);
            }
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProduct formProduct = new FormProduct();
            formProduct.ShowDialog();
        }

        private void btn_cancelSale_Click(object sender, EventArgs e)
        {
            newSale();
            resetLabels();
            dag_productTable.Rows.Clear();
        }

        private void productoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormDeleteProducts frm = new FormDeleteProducts();
            frm.Show();
        }

        private void dag_productTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       private void setProductQuantity(float quantity)
        {
            productList.Last().Quantity = quantity;
        }

       private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
       {
           FormProviders frmProvider = new FormProviders();
           frmProvider.Show();
       }

       private void proveedorToolStripMenuItem1_Click(object sender, EventArgs e)
       {
           FormDeleteProviders frmDeleteProvider = new FormDeleteProviders();
           frmDeleteProvider.Show();
       }

       private void removeProductToList()
       {
           try
           {
               int row = dag_productTable.CurrentRow.Index;
               productList.RemoveAt(row);
               dag_productTable.Rows.RemoveAt(row);
               resetLabels();
               updateSaleValues();
           }
           catch {
               resetLabels();
               updateSaleValues();
           }
       }

       private void btn_deleteProduct_Click(object sender, EventArgs e)
       {
           removeProductToList();
       }

       private void productoToolStripMenuItem2_Click(object sender, EventArgs e)
       {
           FormUpdateProduct frmproduct = new FormUpdateProduct();
           frmproduct.ShowDialog();
       }

       private void provedorToolStripMenuItem_Click(object sender, EventArgs e)
       {
           FormUpdateProvider frmupdateprovider = new FormUpdateProvider();
           frmupdateprovider.ShowDialog();
       }
       private void showLoggedUser()
       {
           this.lbl_user.Text = keepUser;
       }

       private void btn_cashout_Click(object sender, EventArgs e)
       {
           new CashOut();
       }
    }
}
