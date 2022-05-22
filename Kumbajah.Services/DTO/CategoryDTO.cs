using System.Collections.Generic;

namespace Kumbajah.Services.DTO
{
    public class CategoryDTO
    {
        public string Name { get; private set; }
        public virtual IEnumerable<ProductDTO> Products { get; }
        public CategoryDTO() { }

        public CategoryDTO(string name, IEnumerable<ProductDTO> products)
        {
            Name = name;
            Products = products;
        }
    }
}
