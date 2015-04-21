using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_of_Sale
{
    class Product
    {
        public int Id { get; set; }
        public int DiscountPercent { get; set; }
        public string Name { get; set; }
        public int Category { get; set; }
        public float Cost { get; set; }
        public float Price { get; set; }
        public int Provider { get; set; }

        public Product() { 
        
        }

        public Product(int productID) {
            MySqlConnection connection = new MySqlConnection(DBConnect.ConnectionString);
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM product WHERE id=@id", connection);
                command.Parameters.AddWithValue("@id", productID);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable productTable = new DataTable();
                adapter.Fill(productTable);

                DataRow productInfo = productTable.Rows[0];
                this.Id = productID;
                this.Name = (String)productInfo["Name"];
                this.Price = (float)productInfo["Price"];
                this.Provider = (int)productInfo["Provider"];
                this.Category = (int)productInfo["Category"];
                this.Cost = (float)productInfo["Cost"];
                this.DiscountPercent = (int)productInfo["DiscountPercent"];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                if (connection != null) connection.Close();
            }
        }
    }
}
