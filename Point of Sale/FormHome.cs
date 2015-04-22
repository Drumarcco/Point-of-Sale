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
        public FormHome()
        {
            InitializeComponent();
            productList = new BindingList<Lot>();
        }

        private void txt_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                int productID;
                if (! int.TryParse(txt_Search.Text, out productID))
                {
                    DialogProductSearch productSearch = new DialogProductSearch(txt_Search.Text);
                    productSearch.ShowDialog();
                    if (productSearch.DialogResult == DialogResult.OK)
                    {
                        productID = productSearch.productId;
                    }
                    else {
                        txt_Search.Clear();
                        return;
                    }
                }
                addProductToList(productID);
                txt_Search.Clear();
            }
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
    }
}
