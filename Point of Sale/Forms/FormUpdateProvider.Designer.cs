namespace Point_of_Sale
{
    partial class FormUpdateProvider
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.provider_table = new System.Windows.Forms.DataGridView();
            this.providerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            //this._point_of_saleDataSet1 = new Point_of_Sale._point_of_saleDataSet1();
            this.providerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._point_of_saleDataSet = new Point_of_Sale._point_of_saleDataSet();
            this.providerTableAdapter = new Point_of_Sale._point_of_saleDataSetTableAdapters.providerTableAdapter();
            this.providerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            //this.providerTableAdapter1 = new Point_of_Sale._point_of_saleDataSet1TableAdapters.providerTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.provider_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource2)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this._point_of_saleDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._point_of_saleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // provider_table
            // 
            this.provider_table.AllowUserToAddRows = false;
            this.provider_table.AllowUserToDeleteRows = false;
            this.provider_table.AllowUserToOrderColumns = true;
            this.provider_table.AutoGenerateColumns = false;
            this.provider_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.provider_table.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.provider_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.provider_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.provider_table.DataSource = this.providerBindingSource2;
            this.provider_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.provider_table.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.provider_table.Location = new System.Drawing.Point(0, 0);
            this.provider_table.Margin = new System.Windows.Forms.Padding(2);
            this.provider_table.MultiSelect = false;
            this.provider_table.Name = "provider_table";
            this.provider_table.ReadOnly = true;
            this.provider_table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.provider_table.RowTemplate.Height = 24;
            this.provider_table.Size = new System.Drawing.Size(545, 202);
            this.provider_table.TabIndex = 0;
            this.provider_table.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.provider_table_CellContentDoubleClick);
            this.provider_table.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.provider_table_CellDoubleClick);
            // 
            // providerBindingSource2
            // 
            this.providerBindingSource2.DataMember = "provider";
            //this.providerBindingSource2.DataSource = this._point_of_saleDataSet1;
            // 
            // _point_of_saleDataSet1
            // 
            //this._point_of_saleDataSet1.DataSetName = "_point_of_saleDataSet1";
            //this._point_of_saleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // providerBindingSource
            // 
            this.providerBindingSource.DataMember = "provider";
            this.providerBindingSource.DataSource = this._point_of_saleDataSet;
            // 
            // _point_of_saleDataSet
            // 
            this._point_of_saleDataSet.DataSetName = "_point_of_saleDataSet";
            this._point_of_saleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // providerTableAdapter
            // 
            this.providerTableAdapter.ClearBeforeFill = true;
            // 
            // providerBindingSource1
            // 
            this.providerBindingSource1.DataMember = "provider";
            this.providerBindingSource1.DataSource = this._point_of_saleDataSet;
            // 
            // providerTableAdapter1
            // 
            //this.providerTableAdapter1.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Proveedor";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Cellphone";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tel. Celular";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tel. Fijo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // FormUpdateProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(545, 202);
            this.Controls.Add(this.provider_table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormUpdateProvider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.FormUpdateProvider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.provider_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource2)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this._point_of_saleDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._point_of_saleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView provider_table;
        private _point_of_saleDataSet _point_of_saleDataSet;
        private System.Windows.Forms.BindingSource providerBindingSource;
        private _point_of_saleDataSetTableAdapters.providerTableAdapter providerTableAdapter;
        private System.Windows.Forms.BindingSource providerBindingSource1;
        private System.Windows.Forms.BindingSource providerBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}