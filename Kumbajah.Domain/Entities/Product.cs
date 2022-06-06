using Kumbajah.Domain.Validators;
using System;
using System.Collections.Generic;

namespace Kumbajah.Domain.Entities
{
    public class Product : Base
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public string Image { get; private set; }
        public DateTime CreatedAt { get; private set; } = DateTime.Now;
        public virtual Category Category { get; private set; }
        public long CategoryId { get; private set; }
        public virtual Brand Brand { get; private set; }
        public long BrandId { get; private set; }
        public virtual Stock Stock { get; private set; }
        public long StockId { get; private set; }
        public virtual Color Color { get; private set; }
        public long ColorId { get; private set; }
        public virtual IEnumerable<OrderItem> Items { get; }

        public Product() { }

        public Product(string name, string description, decimal price, 
            string image, long stockId, long brandId,
            long categoryId, long colorId)
        {
            Name = name;
            Description = description;
            Price = price;
            Image = image;
            StockId = stockId;
            BrandId = brandId;
            CategoryId = categoryId;
            ColorId = colorId;
            Validate();
        }

        public override bool Validate()
        {
            var validator = new ProductValidator();
            var validation = validator.Validate(this);

            if (!validation.IsValid)
            {
                foreach (var errors in validation.Errors)
                    _errors.Add(errors.ErrorMessage);

                throw new Exception("Alguns campos estão inválidos, por favor corrija-os: " + _errors[0]);
            }
            return true;
        }
    }
}
