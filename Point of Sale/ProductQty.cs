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
    public partial class ProductQty : Form
    {
        public float quantity;
        public ProductQty()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void ProductQty_Load(object sender, EventArgs e)
        {
           
        }

        private void ProductQty_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txt_Qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                btn_ok_Click(null, null);
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txt_Qty.Text, out quantity)){
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {

            }
        }
    }
}
