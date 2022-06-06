using Kumbajah.Domain.Validators;
using System;
using System.Collections.Generic;

namespace Kumbajah.Domain.Entities
{
    public class Address : AbstractAddress
    {
        public virtual IEnumerable<Order> Orders { get; }
        public virtual IEnumerable<User> Users { get; }

        public Address() { }

        public Address(
            string cep, string street,
            int number, string reference, string complement,
            IEnumerable<Order> orders,
            IEnumerable<User> users) :
            base(cep, street, number, reference, complement)
        {
            Orders = orders;
            Users = users;
            Validate();
        }

        public override bool Validate()
        {
            var validator = new AddressValidator();
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
