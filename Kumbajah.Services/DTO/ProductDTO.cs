using Kumbajah.Domain.Entities;
using System;

namespace Kumbajah.Services.DTO
{
    public class ProductDTO
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public string Image { get; private set; }
        public DateTime CreatedTime { get; set; }
        public int CategoryId { get; set; }
        public int StockId { get; set; }
        public int ColorId { get; set; }
        public int BrandId { get; set; }

        public ProductDTO() { }

        public ProductDTO(int id, string name, string description,
            decimal price, string image, DateTime createdTime,
            int categoryId, int stockId, int colorId, int brandId)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Image = image;
            CreatedTime = createdTime;
            CategoryId = categoryId;
            StockId = stockId;
            ColorId = colorId;
            BrandId = brandId;
        }
        
        public ProductDTO(Product product)
        {
            Id = product.Id;
            Name = product.Name;
            Description = product.Description;
            Price = product.Price;
            Image = product.Image;
            CreatedTime = product.CreatedTime;
            CategoryId = product.CategoryId;
            StockId = product.StockId;
            ColorId = product.ColorId.GetValueOrDefault();
            BrandId = product.BrandId;
        }

        public Product GetEntity()
        {
            return new Product
            {
                Id = Id,
                Name = Name,
                Description = Description,
                Price = Price,
                Image = Image,
                CreatedTime = CreatedTime,
                CategoryId = CategoryId,
                StockId = StockId,
                ColorId = ColorId,
                BrandId = BrandId
            };
        }
    }
}
