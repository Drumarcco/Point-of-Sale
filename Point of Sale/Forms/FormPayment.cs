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
    public partial class FormPayment : Form
    {
        public float received;
        public float total;

        public FormPayment(float total)
        {
            InitializeComponent();
            this.total = total;
        }

        private void FormPayment_Load(object sender, EventArgs e)
        {

        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txt_received.Text, out received))
            {
                if (total > received)
                {
                    MessageBox.Show("Dinero insuficiente.");
                    txt_received.Clear();
                }
                else {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
            }
            else {
                MessageBox.Show("Revise que el dato sea numérico.");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_received_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                btn_OK_Click(null, null);
            }
        }
    }
}
