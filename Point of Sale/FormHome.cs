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
        private List<Product> productList;
        public FormHome()
        {
            InitializeComponent();
            productList = new List<Product>();
        }

        private void txt_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                int productID;
                if (! int.TryParse(txt_Search.Text, out productID))
                {
                    DialogProductSearch productSearch = new DialogProductSearch(txt_Search.Text);
                    productSearch.ShowDialog();
                    if (productSearch.DialogResult == DialogResult.OK) {
                        productID = productSearch.productId;
                    }
                }
                Product product = new Product(productID);
                addProductToList(product);
            }
        }

        private void addProductToList(Product product) {
            productList.Add(product);
            updateProductListTable();
        }

        private void updateProductListTable() {
            throw new NotImplementedException();
        }
    }
}
