using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sale
{
    class Lot
    {
        public int Quantity { get; set; }
        public Product Product { get; set; }
        public float Subtotal { get; set; }

        public Lot(Product product, int quantity)
        {
            Subtotal = product.Price * quantity;
        }
    }
}
