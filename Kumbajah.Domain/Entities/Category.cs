using System.Collections.Generic;

namespace Kumbajah.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Product> Products { get; set; }

        public Category() { }

        public Category(string name)
        {
            Name = name;
        }
    }
}
