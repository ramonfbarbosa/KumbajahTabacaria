using System.Collections.Generic;

namespace Kumbajah.Domain.Entities
{
    public class Category
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public virtual IEnumerable<Product> Products { get; }

        public Category() { }

        public Category(string name, IEnumerable<Product> products)
        {
            Name = name;
            Products = products;
        }
    }
}
