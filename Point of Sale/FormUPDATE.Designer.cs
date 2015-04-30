namespace Point_of_Sale
{
    partial class FormUPDATE
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_category = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_provider = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Búsqueda:";
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(94, 25);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(283, 22);
            this.txt_Search.TabIndex = 2;
            this.txt_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Search_KeyDown);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(208, 261);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 28);
            this.btn_cancel.TabIndex = 23;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(94, 261);
            this.btn_update.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(100, 28);
            this.btn_update.TabIndex = 22;
            this.btn_update.Text = "Actualizar";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(94, 224);
            this.txt_price.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(281, 22);
            this.txt_price.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 227);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Precio:";
            // 
            // txt_cost
            // 
            this.txt_cost.Location = new System.Drawing.Point(94, 187);
            this.txt_cost.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txt_cost.Name = "txt_cost";
            this.txt_cost.Size = new System.Drawing.Size(281, 22);
            this.txt_cost.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Costo:";
            // 
            // cbx_category
            // 
            this.cbx_category.DisplayMember = "Name";
            this.cbx_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_category.FormattingEnabled = true;
            this.cbx_category.Location = new System.Drawing.Point(94, 147);
            this.cbx_category.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cbx_category.Name = "cbx_category";
            this.cbx_category.Size = new System.Drawing.Size(281, 24);
            this.cbx_category.TabIndex = 17;
            this.cbx_category.ValueMember = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Categoria:";
            // 
            // cbx_provider
            // 
            this.cbx_provider.DisplayMember = "Name";
            this.cbx_provider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_provider.FormattingEnabled = true;
            this.cbx_provider.Location = new System.Drawing.Point(94, 109);
            this.cbx_provider.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cbx_provider.Name = "cbx_provider";
            this.cbx_provider.Size = new System.Drawing.Size(283, 24);
            this.cbx_provider.TabIndex = 15;
            this.cbx_provider.ValueMember = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Proveedor:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(94, 72);
            this.txt_name.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(283, 22);
            this.txt_name.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 76);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nombre:";
            // 
            // FormUPDATE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 302);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_cost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbx_category);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbx_provider);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Search);
            this.Name = "FormUPDATE";
            this.Text = "FormUPDATE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_cost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_category;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_provider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label6;
    }
}