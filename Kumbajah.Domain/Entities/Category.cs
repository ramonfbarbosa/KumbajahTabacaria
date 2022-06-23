using System.Collections.Generic;

namespace Kumbajah.Domain.Entities
{
    public class Category
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public virtual List<Product> Products { get; }

        public Category() { }

        public Category(string name) 
        {
            Name = name;
        }
    }
}
