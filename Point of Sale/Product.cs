using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sale
{
    class Product
    {
        public int Id { get; set; }
        public int DiscountPercent { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public float Cost { get; set; }
        public float Price { get; set; }
        
    }
}
