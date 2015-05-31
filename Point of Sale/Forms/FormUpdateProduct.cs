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
        private Inventory inventory;
        private String IdaddInventory;
        private String NameaddInventory;

        public FormUpdateProduct()
        {
            InitializeComponent();
        }

        private void FormUpdateProduct_Load(object sender, EventArgs e)
        {
            try
            {
                this.productTableAdapter.Fill(this._point_of_saleDataSet.product);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }


        private void product_table_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String ID = product_table.CurrentRow.Cells[0].Value.ToString();
            frmproduct = new FormProduct(int.Parse(ID));
            frmproduct.ShowDialog();

            if (frmproduct.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                this.productTableAdapter.Fill(this._point_of_saleDataSet.product);
            }
        }

        private void product_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void product_table_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.Button == MouseButtons.Right)
                {

                    DataGridViewCell clickedCell = (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex];
                    this.product_table.CurrentCell = clickedCell;
                    var mousePosition = product_table.PointToClient(Cursor.Position);
                    IdaddInventory = product_table.CurrentRow.Cells[0].Value.ToString();
                    NameaddInventory = product_table.CurrentRow.Cells[1].Value.ToString();
                    cms_MouseClickRight.Show(product_table, mousePosition);
                }
            }
        }

        private void addInventoryToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                FormAddDeleteInventory addinventory = new FormAddDeleteInventory(int.Parse(IdaddInventory), NameaddInventory,true);
                addinventory.ShowDialog();
            }   
        }

        private void deleteInventoryToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                FormAddDeleteInventory addinventory = new FormAddDeleteInventory(int.Parse(IdaddInventory), NameaddInventory,false);
                addinventory.ShowDialog();
            } 
        }

        private void tbx_filtro_TextChanged(object sender, EventArgs e)
        {
            this.productBindingSource1 = new BindingSource();
            productBindingSource1.DataSource = product_table.DataSource;
            productBindingSource1.Filter = "[Name] Like '%" + tbx_filtro.Text + "%'";
            product_table.DataSource = productBindingSource1;
        }
    }
}
