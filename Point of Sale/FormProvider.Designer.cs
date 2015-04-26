namespace Point_of_Sale
{
    partial class FormProvider
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
            this.brn_save = new System.Windows.Forms.Button();
            this.brn_cancel = new System.Windows.Forms.Button();
            this.txb_nameProvider = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_idProvider = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_addressProvider = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_phoneProvider = new System.Windows.Forms.TextBox();
            this.txb_cellProvider = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // brn_save
            // 
            this.brn_save.Location = new System.Drawing.Point(65, 188);
            this.brn_save.Name = "brn_save";
            this.brn_save.Size = new System.Drawing.Size(75, 23);
            this.brn_save.TabIndex = 0;
            this.brn_save.Text = "Guardar";
            this.brn_save.UseVisualStyleBackColor = true;
            // 
            // brn_cancel
            // 
            this.brn_cancel.Location = new System.Drawing.Point(146, 188);
            this.brn_cancel.Name = "brn_cancel";
            this.brn_cancel.Size = new System.Drawing.Size(75, 23);
            this.brn_cancel.TabIndex = 1;
            this.brn_cancel.Text = "Cancelar";
            this.brn_cancel.UseVisualStyleBackColor = true;
            // 
            // txb_nameProvider
            // 
            this.txb_nameProvider.Location = new System.Drawing.Point(65, 56);
            this.txb_nameProvider.Name = "txb_nameProvider";
            this.txb_nameProvider.Size = new System.Drawing.Size(318, 20);
            this.txb_nameProvider.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // cbx_idProvider
            // 
            this.cbx_idProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_idProvider.FormattingEnabled = true;
            this.cbx_idProvider.Location = new System.Drawing.Point(65, 29);
            this.cbx_idProvider.Name = "cbx_idProvider";
            this.cbx_idProvider.Size = new System.Drawing.Size(75, 21);
            this.cbx_idProvider.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Direccion:";
            // 
            // txb_addressProvider
            // 
            this.txb_addressProvider.Location = new System.Drawing.Point(65, 82);
            this.txb_addressProvider.Name = "txb_addressProvider";
            this.txb_addressProvider.Size = new System.Drawing.Size(318, 20);
            this.txb_addressProvider.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefono:";
            // 
            // txb_phoneProvider
            // 
            this.txb_phoneProvider.Location = new System.Drawing.Point(65, 108);
            this.txb_phoneProvider.Name = "txb_phoneProvider";
            this.txb_phoneProvider.Size = new System.Drawing.Size(200, 20);
            this.txb_phoneProvider.TabIndex = 9;
            // 
            // txb_cellProvider
            // 
            this.txb_cellProvider.Location = new System.Drawing.Point(65, 134);
            this.txb_cellProvider.Name = "txb_cellProvider";
            this.txb_cellProvider.Size = new System.Drawing.Size(200, 20);
            this.txb_cellProvider.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Celular:";
            // 
            // FormProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 226);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_cellProvider);
            this.Controls.Add(this.txb_phoneProvider);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_addressProvider);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_idProvider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_nameProvider);
            this.Controls.Add(this.brn_cancel);
            this.Controls.Add(this.brn_save);
            this.Name = "FormProvider";
            this.Text = "Proveedor";
            this.Load += new System.EventHandler(this.FormProvider_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button brn_save;
        private System.Windows.Forms.Button brn_cancel;
        private System.Windows.Forms.TextBox txb_nameProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_idProvider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_addressProvider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_phoneProvider;
        private System.Windows.Forms.TextBox txb_cellProvider;
        private System.Windows.Forms.Label label5;
    }
}