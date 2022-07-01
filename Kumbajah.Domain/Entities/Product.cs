using System;
using System.Collections.Generic;

namespace Kumbajah.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public DateTime CreatedTime { get; set; }
        public virtual Category Category { get; set; }
        public int CategoryId { get; set; }
        public virtual Brand Brand { get; set; }
        public int BrandId { get; set; }
        public virtual Stock Stock { get; set; }
        public int StockId { get; set; }
        public virtual Color Color { get; set; }
        public int? ColorId { get; set; }
        public virtual List<OrderItem> Items { get; set; }

        public Product() { }

        public Product(string name, string description, decimal price,
            string image, int stockId, int brandId,
            int categoryId, int? colorId = null)
        {
            Name = name;
            Description = description;
            Price = price;
            Image = image;
            StockId = stockId;
            BrandId = brandId;
            CategoryId = categoryId;
            ColorId = (int)colorId;
        }
    }
}
