namespace Point_of_Sale
{
    partial class FormProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_provider = new System.Windows.Forms.ComboBox();
            this.providerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._point_of_saleDataSet1 = new Point_of_Sale._point_of_saleDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_category = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.providerTableAdapter1 = new Point_of_Sale._point_of_saleDataSetTableAdapters.providerTableAdapter();
            this.categoryTableAdapter = new Point_of_Sale._point_of_saleDataSetTableAdapters.categoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._point_of_saleDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(79, 14);
            this.txt_name.Margin = new System.Windows.Forms.Padding(5);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(213, 20);
            this.txt_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Proveedor:";
            // 
            // cbx_provider
            // 
            this.cbx_provider.DataSource = this.providerBindingSource;
            this.cbx_provider.DisplayMember = "Name";
            this.cbx_provider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_provider.FormattingEnabled = true;
            this.cbx_provider.Location = new System.Drawing.Point(79, 44);
            this.cbx_provider.Margin = new System.Windows.Forms.Padding(5);
            this.cbx_provider.Name = "cbx_provider";
            this.cbx_provider.Size = new System.Drawing.Size(213, 21);
            this.cbx_provider.TabIndex = 3;
            this.cbx_provider.ValueMember = "ID";
            // 
            // providerBindingSource
            // 
            this.providerBindingSource.DataMember = "provider";
            this.providerBindingSource.DataSource = this._point_of_saleDataSet1;
            // 
            // _point_of_saleDataSet1
            // 
            this._point_of_saleDataSet1.DataSetName = "_point_of_saleDataSet";
            this._point_of_saleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Categoria:";
            // 
            // cbx_category
            // 
            this.cbx_category.DataSource = this.categoryBindingSource;
            this.cbx_category.DisplayMember = "Name";
            this.cbx_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_category.FormattingEnabled = true;
            this.cbx_category.Location = new System.Drawing.Point(79, 75);
            this.cbx_category.Margin = new System.Windows.Forms.Padding(5);
            this.cbx_category.Name = "cbx_category";
            this.cbx_category.Size = new System.Drawing.Size(212, 21);
            this.cbx_category.TabIndex = 5;
            this.cbx_category.ValueMember = "ID";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "category";
            this.categoryBindingSource.DataSource = this._point_of_saleDataSet1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Costo:";
            // 
            // txt_cost
            // 
            this.txt_cost.Location = new System.Drawing.Point(79, 107);
            this.txt_cost.Margin = new System.Windows.Forms.Padding(5);
            this.txt_cost.Name = "txt_cost";
            this.txt_cost.Size = new System.Drawing.Size(212, 20);
            this.txt_cost.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Precio:";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(79, 137);
            this.txt_price.Margin = new System.Windows.Forms.Padding(5);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(212, 20);
            this.txt_price.TabIndex = 9;
            this.txt_price.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_price_KeyDown);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(79, 167);
            this.btn_save.Margin = new System.Windows.Forms.Padding(5);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Guardar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(164, 167);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(5);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // providerTableAdapter1
            // 
            this.providerTableAdapter1.ClearBeforeFill = true;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 204);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_cost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbx_category);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbx_provider);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Name = "FormProduct";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._point_of_saleDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_provider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_category;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private _point_of_saleDataSet _point_of_saleDataSet;
        private _point_of_saleDataSetTableAdapters.providerTableAdapter providerTableAdapter;
        private _point_of_saleDataSet _point_of_saleDataSet1;
        private System.Windows.Forms.BindingSource providerBindingSource;
        private _point_of_saleDataSetTableAdapters.providerTableAdapter providerTableAdapter1;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private _point_of_saleDataSetTableAdapters.categoryTableAdapter categoryTableAdapter;
    }
}