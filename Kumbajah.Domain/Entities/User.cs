using Kumbajah.Core.Exceptions;
using Kumbajah.Domain.Validators;
using System;
using System.Collections.Generic;

namespace Kumbajah.Domain.Entities
{
    public class User : Base
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        public string Password { get; set; }
        public string? CPF { get; set; }
        public string? PhoneNumber { get; set; }
        public virtual List<Address> Addresses { get; }
        public virtual List<Order> Orders { get; }

        public User() { }

        public User(string name, string lastName,
            string email, DateTime birthdate, string password,
            string? cpf = null, string? phoneNumber = null)
        {
            Name = name;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Birthdate = birthdate;
            Password = password;
            CPF = cpf;
            Addresses = new List<Address>();
            Orders = new List<Order>();
            _errors = new List<string>();
            Validate();
        }

        public override bool Validate()
        {
            var validator = new UserValidator();
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
