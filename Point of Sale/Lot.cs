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
        public float Subtotal { get { return _subtotal * Quantity; } set { this._subtotal = value; } }

        private float _subtotal = 0;

        public Lot(Product product, int quantity)
        {
            this.Product = product;
            this.Quantity = quantity;
            Subtotal = product.getRealPrice() * quantity;
        }
    }
}
