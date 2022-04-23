using Kumbajah.Domain.Validators;
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
        public Category Category { get; private set; }

        public Product() { }

        public Product(string name, string description, decimal price, string image, long quantity, Category category)
        {
            Name = name;
            Description = description;
            Price = price;
            Image = image;
            Quantity = quantity;
            Category = category;
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
