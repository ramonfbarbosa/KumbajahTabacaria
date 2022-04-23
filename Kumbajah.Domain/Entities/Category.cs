using Kumbajah.Domain.Validators;
using System;
using System.Collections.Generic;

namespace Kumbajah.Domain.Entities
{
    public class Category : Base
    {
        public string Name { get; private set; }
        public IEnumerable<Product> Products { get; }

        public Category() { }

        public Category(string name, IEnumerable<Product> products)
        {
            Name = name;
            Products = products;
        }

        public override bool Validate()
        {
            var validator = new CategoryValidator();
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
