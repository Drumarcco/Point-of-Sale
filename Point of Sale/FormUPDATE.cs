using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_of_Sale
{
    public partial class FormUPDATE : Form
    {
        public FormUPDATE()
        {
            InitializeComponent();
        }

        private void txt_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int productID;
                if (!int.TryParse(txt_Search.Text, out productID))
                {
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
              //  addProductToList(productID);
                txt_Search.Clear();
            }
        }
    }
}
