using System;
using System.Collections.Generic;

namespace Kumbajah.Domain.Entities
{
    public class Category : Base
    {
        public string Name { get; private set; }
        public IEnumerable<Product> Products { get; }

        public Category() { }

        public Category(string name, DateTime createdAt, DateTime updatedAt, IEnumerable<Product> products)
        {
            Name = name;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Products = products;
        }

        public override bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}
