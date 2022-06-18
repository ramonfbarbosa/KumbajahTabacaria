using Kumbajah.Domain.Validators;
using System;
using System.Collections.Generic;

namespace Kumbajah.Domain.Entities
{
    public class Address : Base
    {
        public string CEP { get; private set; }
        public string Street { get; private set; }
        public string State { get; private set; }
        public string City { get; private set; }
        public string District { get; private set; }
        public int Number { get; private set; }
        public string? Complement { get; private set; }
        public string Reference { get; private set; }
        public virtual IEnumerable<Order> Orders { get; }
        public virtual IEnumerable<User> Users { get; }

        public Address() { }

        public Address(
            string cep, string street, string state,
            string city, string district,
            int number, string reference,
            IEnumerable<Order> orders,
            IEnumerable<User> users, 
            string? complement = null)
        {
            CEP = cep;
            Street = street;
            State = state;
            City = city;
            District = district;
            Number = number;
            Reference = reference;
            Complement = complement;
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
