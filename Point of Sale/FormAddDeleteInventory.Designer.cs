﻿namespace Point_of_Sale
{
    partial class FormAddDeleteInventory
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
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_nameProduct = new System.Windows.Forms.TextBox();
            this.txb_quantity = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(67, 102);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Guardar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad";
            // 
            // txb_nameProduct
            // 
            this.txb_nameProduct.Location = new System.Drawing.Point(67, 25);
            this.txb_nameProduct.Name = "txb_nameProduct";
            this.txb_nameProduct.ReadOnly = true;
            this.txb_nameProduct.Size = new System.Drawing.Size(209, 20);
            this.txb_nameProduct.TabIndex = 3;
            // 
            // txb_quantity
            // 
            this.txb_quantity.Location = new System.Drawing.Point(67, 65);
            this.txb_quantity.Name = "txb_quantity";
            this.txb_quantity.Size = new System.Drawing.Size(209, 20);
            this.txb_quantity.TabIndex = 4;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(148, 102);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // FormAddInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 149);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.txb_quantity);
            this.Controls.Add(this.txb_nameProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_save);
            this.Name = "FormAddInventory";
            this.Text = "Inventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_nameProduct;
        private System.Windows.Forms.TextBox txb_quantity;
        private System.Windows.Forms.Button btn_cancel;
    }
}