using System.Collections.Generic;

namespace Kumbajah.Domain.Entities
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Product> Products { get; set; }

        public Brand() { }

        public Brand(string name)
        {
            Name = name;
        }
    }
}
