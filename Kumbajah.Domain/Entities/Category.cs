using System.Collections.Generic;

namespace Kumbajah.Domain.Entities
{
    public class Category : Base
    {
        public string Name { get; private set; }
        public virtual IEnumerable<Product> Products { get; }
        public long ProductId { get; private set; }

        public Category() { }

        public Category(string name, long productId)
        {
            Name = name;
            ProductId = productId;
        }
    }
}
