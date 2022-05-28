using System;

namespace Kumbajah.Domain.Entities
{
    public class Product : Base
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public string Image { get; private set; }
        public long Quantity { get; private set; }
        public string Brand { get; private set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public virtual Category Category { get; private set; }
        public long CategoryId { get; private set; }

        public Product() { }

        public Product(string name, string description, decimal price, string image, long quantity,
            string brand, DateTime createdTime, long categoryId, DateTime? updateTime = null)
        {
            Name = name;
            Description = description;
            Price = price;
            Image = image;
            Quantity = quantity;
            Brand = brand;
            CreatedTime = createdTime;
            UpdateTime = updateTime;
            CategoryId = categoryId;
        }
    }
}
