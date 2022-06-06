using Kumbajah.Domain.Validators;
using System;
using System.Collections.Generic;

namespace Kumbajah.Domain.Entities
{
    public class User : Base
    {
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public DateTime Birthdate { get; private set; }
        public string Password { get; private set; }
        public string ConfirmPassword { get; private set; }
        public string? CPF { get; private set; }
        public string? PhoneNumber { get; private set; }
        public virtual IEnumerable<Address> Addresses { get; }
        public virtual IEnumerable<Order> Orders { get; }

        public User() { }

        //perguntar pro saulo sobre o defaultadress = null e pq o Order nao é
        public User(string name, string lastName,
            string email, DateTime birthdate, string password,
            string? cpf = null, string? phoneNumber = null,
            IEnumerable<Address>? addresses = null,
            IEnumerable<Order>? orders = null)
        {
            Name = name;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Birthdate = birthdate;
            Password = password;
            CPF = cpf;
            Addresses = addresses;
            Orders = orders;
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

                throw new Exception("Alguns campos estão inválidos, por favor corrija-os: " + _errors[0]);
            }
            return true;
        }

        public void ChangeName(string name)
        {
            Name = name;
            Validate();
        }

        public void ChangeLastName(string lastName)
        {
            LastName = lastName;
            Validate();
        }

        public void ChangePhoneNumber(string phoneNumber)
        {
            //PhoneNumber = phoneNumber;
            Validate();
        }

        public void ChangeEmail(string email)
        {
            Email = email;
            Validate();
        }

        public void ChangePassword(string password)
        {
            Password = password;
            Validate();
        }
    }
}
