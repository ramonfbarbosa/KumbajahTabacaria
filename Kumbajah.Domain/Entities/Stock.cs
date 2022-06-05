using System.Collections.Generic;

namespace Kumbajah.Domain.Entities
{
    public class Stock
    {
        public long Id { get; private set; }
        public virtual IEnumerable<Product> Products { get; }
        public int Quantity { get; private set; }

        public Stock() { }

        public Stock(int quantity, IEnumerable<Product> products)
        {
            Quantity = quantity;
            Products = products;
        }
    }
}
