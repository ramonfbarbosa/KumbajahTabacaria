using Kumbajah.Core.Exceptions;
using Kumbajah.Domain.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Column("CATEGORY_ID")]
        public int CategoryId { get; private set; }
        public virtual Brand Brand { get; private set; }
        [Column("BRAND_ID")]
        public int BrandId { get; private set; }
        public virtual Stock Stock { get; private set; }
        [Column("STOCK_ID")]
        public int StockId { get; private set; }
        public virtual Color Color { get; private set; }
        [Column("COLOR_ID")]
        public int ColorId { get; private set; }
        public virtual List<OrderItem> Items { get; }

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

                throw new DomainException("Alguns campos estão inválidos, por favor corrija-os: ", _errors);
            }
            return true;
        }
    }
}
