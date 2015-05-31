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
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providerBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this._point_of_saleDataSet = new Point_of_Sale._point_of_saleDataSet();
            this.providerTableAdapter = new Point_of_Sale._point_of_saleDataSetTableAdapters.providerTableAdapter();
            this.pointofsaleDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_filter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.provider_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._point_of_saleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointofsaleDataSetBindingSource)).BeginInit();
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
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.phoneDataGridViewTextBoxColumn,
            this.cellphoneDataGridViewTextBoxColumn});
            this.provider_table.DataSource = this.providerBindingSource3;
            this.provider_table.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.provider_table.Location = new System.Drawing.Point(11, 46);
            this.provider_table.Margin = new System.Windows.Forms.Padding(2);
            this.provider_table.MultiSelect = false;
            this.provider_table.Name = "provider_table";
            this.provider_table.ReadOnly = true;
            this.provider_table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.provider_table.RowTemplate.Height = 24;
            this.provider_table.Size = new System.Drawing.Size(798, 317);
            this.provider_table.TabIndex = 0;
            this.provider_table.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.provider_table_CellContentDoubleClick);
            this.provider_table.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.provider_table_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn5.HeaderText = "Dirección";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Tel. Fijo";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cellphoneDataGridViewTextBoxColumn
            // 
            this.cellphoneDataGridViewTextBoxColumn.DataPropertyName = "Cellphone";
            this.cellphoneDataGridViewTextBoxColumn.HeaderText = "Tel. Celular";
            this.cellphoneDataGridViewTextBoxColumn.Name = "cellphoneDataGridViewTextBoxColumn";
            this.cellphoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // providerBindingSource3
            // 
            this.providerBindingSource3.DataMember = "provider";
            this.providerBindingSource3.DataSource = this._point_of_saleDataSet;
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
            // pointofsaleDataSetBindingSource
            // 
            this.pointofsaleDataSetBindingSource.DataSource = this._point_of_saleDataSet;
            this.pointofsaleDataSetBindingSource.Position = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtro:";
            // 
            // tbx_filter
            // 
            this.tbx_filter.Location = new System.Drawing.Point(51, 10);
            this.tbx_filter.Name = "tbx_filter";
            this.tbx_filter.Size = new System.Drawing.Size(757, 20);
            this.tbx_filter.TabIndex = 2;
            this.tbx_filter.TextChanged += new System.EventHandler(this.tbx_filter_TextChanged);
            // 
            // FormUpdateProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(824, 381);
            this.Controls.Add(this.tbx_filter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.provider_table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormUpdateProvider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.FormUpdateProvider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.provider_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._point_of_saleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointofsaleDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView provider_table;
        private _point_of_saleDataSet _point_of_saleDataSet;
        private _point_of_saleDataSetTableAdapters.providerTableAdapter providerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource pointofsaleDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource providerBindingSource3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_filter;
    }
}