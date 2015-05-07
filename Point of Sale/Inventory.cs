using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sale
{
    class Inventory
    {
        public int Id { get; set; }
        public float quantity { get; set; }
        public String nameProduct { get; set; }
        public bool addordelete { get; set; }

        public Inventory(int Id, String nameProduct, bool addordelete) {
            this.Id = Id;
            this.nameProduct = nameProduct;
            this.addordelete = addordelete;
        }

    }
}
