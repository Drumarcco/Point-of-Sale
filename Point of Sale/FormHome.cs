﻿using System;
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
    public partial class FormHome : Form
    {
        private BindingList<Lot> productList;
        private float subtotal;
        private float tax;
        private float total;
        private bool saleIsActive;

        public FormHome()
        {
            InitializeComponent();
            newSale();
        }

        private void setSubtotal()
        {
            float subtotal = 0;
            foreach (Lot lot in productList) {
                subtotal += lot.Product.getRealPrice() * lot.Quantity;
            }
            this.subtotal = subtotal;
        }

        private void setTax(float subtotal) {
            this.tax = (float)(subtotal * 0.16);
        }

        private void setTotal(float subtotal, float tax) {
            this.total = subtotal + tax;
        }

        private void updateSaleValues() {
            setSubtotal();
            setTax(subtotal);
            setTotal(subtotal, tax);
            lbl_subtotal.Text = subtotal.ToString("C2");
            lbl_tax.Text = tax.ToString("C2");
            lbl_total.Text = total.ToString("C2");
        }


        private void txt_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                if (!saleIsActive) {
                    newSale();
                }
                int productID;
                if (! int.TryParse(txt_Search.Text, out productID))
                {
                    if (txt_Search.Text.Trim() == "" && productList.Count > 0)
                    {
                        endSale();
                        return;
                    }
                    else {
                        DialogProductSearch productSearch = new DialogProductSearch(txt_Search.Text);
                        productSearch.ShowDialog();
                        if (productSearch.DialogResult == DialogResult.OK)
                        {
                            productID = productSearch.productId;
                        }
                        else
                        {
                            txt_Search.Clear();
                            return;
                        }
                    }
                }
                addProductToList(productID);
                txt_Search.Clear();
            }
        }

        private void newSale() {
            productList = new BindingList<Lot>();
            subtotal = 0;
            tax = 0;
            total = 0;
            saleIsActive = true;
            resetLabels();
        }

        private void resetLabels() {
            lbl_change.Text = "-";
            lbl_received.Text = "-";
            lbl_subtotal.Text = "-";
            lbl_tax.Text = "-";
            lbl_total.Text = "-";
        }

        private void endSale() {
            FormPayment formPayment = new FormPayment(this.total);
            formPayment.ShowDialog();
            if (formPayment.DialogResult == System.Windows.Forms.DialogResult.OK) {
                lbl_received.Text = formPayment.received.ToString("C2");
                updateChange(formPayment.received);
                saleIsActive = false;
            }
        }

        private void updateChange(float received) {
            float change = received - total;
            lbl_change.Text = change.ToString("C2");
        }

        private void addProductToList(int productID) {
            try
            {
                Product product = new Product(productID);
                if (isProductOnList(product))
                {
                    int lotIndex = getLotIndexFromList(product);
                    Lot lot = productList[lotIndex];
                    lot.Quantity++;
                    productList[lotIndex] = lot;
                }
                else
                {
                    Lot lot = new Lot(product, 1);
                    productList.Add(lot);
                }
                updateProductListTable();
                updateSaleValues();
            }
            catch (ArgumentException argEx) {
                MessageBox.Show(argEx.Message);
            }
            
        }

        private bool isProductOnList(Product product) {
            foreach (Lot lot in productList) {
                if (lot.Product.Id == product.Id) return true;
            }
            return false;
        }

        private int getLotIndexFromList(Product product) { 
            int i = 0;
            foreach (Lot lot in productList) {
                if (lot.Product.Id == product.Id)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }


        private void updateProductListTable() {
            dag_productTable.Rows.Clear();
            foreach (Lot lot in productList) {
                DataGridViewRow row = (DataGridViewRow)dag_productTable.Rows[0].Clone();
                row.Cells[1].Value = lot.Product.Name;
                row.Cells[2].Value = lot.Quantity;
                row.Cells[3].Value = lot.Product.getRealPrice();
                row.Cells[4].Value = lot.Product.getDiscount();
                row.Cells[5].Value = lot.Subtotal;
                dag_productTable.Rows.Add(row);
            }
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProduct formProduct = new FormProduct();
            formProduct.ShowDialog();
        }
    }
}
