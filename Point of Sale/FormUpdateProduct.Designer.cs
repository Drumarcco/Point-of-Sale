namespace Point_of_Sale
{
    partial class FormUpdateProduct
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
            this.product_table = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountPercentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._point_of_saleDataSet = new Point_of_Sale._point_of_saleDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new Point_of_Sale._point_of_saleDataSetTableAdapters.productTableAdapter();
            this.cms_MouseClickRight = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.product_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._point_of_saleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.cms_MouseClickRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // product_table
            // 
            this.product_table.AllowUserToAddRows = false;
            this.product_table.AllowUserToDeleteRows = false;
            this.product_table.AllowUserToOrderColumns = true;
            this.product_table.AutoGenerateColumns = false;
            this.product_table.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.product_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.discountPercentDataGridViewTextBoxColumn,
            this.providerDataGridViewTextBoxColumn});
            this.product_table.DataSource = this.productBindingSource1;
            this.product_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.product_table.Location = new System.Drawing.Point(0, 0);
            this.product_table.Margin = new System.Windows.Forms.Padding(2);
            this.product_table.Name = "product_table";
            this.product_table.ReadOnly = true;
            this.product_table.Size = new System.Drawing.Size(746, 180);
            this.product_table.TabIndex = 0;
            this.product_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.product_table_CellClick);
            this.product_table.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.product_table_CellDoubleClick);
            this.product_table.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.product_table_CellMouseClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // discountPercentDataGridViewTextBoxColumn
            // 
            this.discountPercentDataGridViewTextBoxColumn.DataPropertyName = "DiscountPercent";
            this.discountPercentDataGridViewTextBoxColumn.HeaderText = "DiscountPercent";
            this.discountPercentDataGridViewTextBoxColumn.Name = "discountPercentDataGridViewTextBoxColumn";
            this.discountPercentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // providerDataGridViewTextBoxColumn
            // 
            this.providerDataGridViewTextBoxColumn.DataPropertyName = "Provider";
            this.providerDataGridViewTextBoxColumn.HeaderText = "Provider";
            this.providerDataGridViewTextBoxColumn.Name = "providerDataGridViewTextBoxColumn";
            this.providerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "product";
            this.productBindingSource1.DataSource = this._point_of_saleDataSet;
            // 
            // _point_of_saleDataSet
            // 
            this._point_of_saleDataSet.DataSetName = "_point_of_saleDataSet";
            this._point_of_saleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this._point_of_saleDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // cms_MouseClickRight
            // 
            this.cms_MouseClickRight.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addInventoryToolStripMenuItem,
            this.deleteInventoryToolStripMenuItem});
            this.cms_MouseClickRight.Name = "cms_MouseClickRight";
            this.cms_MouseClickRight.Size = new System.Drawing.Size(190, 48);
            // 
            // addInventoryToolStripMenuItem
            // 
            this.addInventoryToolStripMenuItem.Name = "addInventoryToolStripMenuItem";
            this.addInventoryToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.addInventoryToolStripMenuItem.Text = "Agregar a Inventario";
            this.addInventoryToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.addInventoryToolStripMenuItem_MouseDown);
            // 
            // deleteInventoryToolStripMenuItem
            // 
            this.deleteInventoryToolStripMenuItem.Name = "deleteInventoryToolStripMenuItem";
            this.deleteInventoryToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.deleteInventoryToolStripMenuItem.Text = "Eliminar de Inventario";
            this.deleteInventoryToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.deleteInventoryToolStripMenuItem_MouseDown);
            // 
            // FormUpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 180);
            this.Controls.Add(this.product_table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormUpdateProduct";
            this.Text = "FormUpdateProduct";
            this.Load += new System.EventHandler(this.FormUpdateProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.product_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._point_of_saleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.cms_MouseClickRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView product_table;
        private _point_of_saleDataSet _point_of_saleDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private _point_of_saleDataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountPercentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn providerDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.ContextMenuStrip cms_MouseClickRight;
        private System.Windows.Forms.ToolStripMenuItem addInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteInventoryToolStripMenuItem;
    }
}