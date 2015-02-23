using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sale
{
    class Sale
    {
        public int Id { get; set; }
        public List<Lot> LotsList { get; set; }
        public float Total { get; set; }
        public DateTime TimeStamp { get; set; }
        public User Salesman { get; set; }

        /// <summary>
        /// Create a new sale transaction.
        /// </summary>
        /// <param name="salesman">Salesman object to include it's info</param>
        public Sale(User salesman)
        {
            TimeStamp = new DateTime();
        }

        /// <summary>
        /// Retrieve a previous sale information.
        /// </summary>
        /// <param name="id">The id number of the sale to review.</param>
        public Sale(int id)
        {
            throw new NotImplementedException();
        }
    }
}
