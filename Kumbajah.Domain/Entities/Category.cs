using System.Collections.Generic;

namespace Kumbajah.Domain.Entities
{
    public class Category : Base
    {
        public string Name { get; private set; }
        public virtual IEnumerable<Product> Products { get; }
        public int ProductId { get; private set; }

        public Category() { }

        public Category(string name, IEnumerable<Product> products)
        {
            Name = name;
            Products = products;
        }
    }
}
