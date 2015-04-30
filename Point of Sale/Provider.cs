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
    class Provider
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cellphone { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public Provider() { }

        public Provider(int providerID)
        {
            MySqlConnection connection = new MySqlConnection(DBConnect.ConnectionString);

            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM provider WHERE id=@id", connection);
                command.Parameters.AddWithValue("@ID", providerID);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable providerTable = new DataTable();
                adapter.Fill(providerTable);

                if (providerTable.Rows.Count > 0)
                {
                    DataRow productInfo = providerTable.Rows[0];
                    this.Id = providerID;
                    this.Name = (String)productInfo["Name"];
                    this.Address = (String)productInfo["Address"];
                    this.Cellphone = (String) productInfo["Cellphone"];
                    this.Phone = (String) productInfo ["Phone"];
                }
                else
                {
                    //throw new ArgumentException("No se encontró el Proveedor, "
                    //+ "favor de registrarlo.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null) connection.Close();
            }

        }

    }
}

        



