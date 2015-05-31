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
    public partial class FormUpdateProvider : Form
    {
        private FormProviders frmprovider;
        private MySqlDataAdapter dataAdapter;
        private DataSet dataSet;                 
        private string sTable = "provider"; 

        public FormUpdateProvider()
        {
            InitializeComponent();
        }

        private void FormUpdateProvider_Load(object sender, EventArgs e)
        { 
            this.providerTableAdapter.Fill(this._point_of_saleDataSet.provider);
        }

        private void provider_table_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        } 

        private void provider_table_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String ID = provider_table.CurrentRow.Cells[0].Value.ToString();
            frmprovider = new FormProviders(int.Parse(ID));
            frmprovider.ShowDialog();

            if (frmprovider.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                this.providerTableAdapter.Fill(this._point_of_saleDataSet.provider);
            }

        }

        private void tbx_filter_TextChanged(object sender, EventArgs e)
        {
            this.providerBindingSource3 = new BindingSource();
            providerBindingSource3.DataSource = provider_table.DataSource;
            providerBindingSource3.Filter = "[Name] Like '%" + tbx_filter.Text + "%'";
            provider_table.DataSource = providerBindingSource3;
        }
    }
}
