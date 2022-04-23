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
        public string PhoneNumber { get; private set; }
        public string Birthday { get; private set; }
        public string Password { get; private set; }
        public string CPF { get; private set; }

        public User() {}

        public User(string name,string lastName, string email, string phoneNumber, string birthday, string password, string cpf)
        {
            Name = name;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Birthday = birthday;
            Password = password;
            CPF = cpf;
            _errors = new List<string>();
        }

        public override bool Validate()
        {
            var validator = new UserValidator();
            var validation = validator.Validate(this);

            if (!validation.IsValid)
            {
                foreach(var errors in validation.Errors)
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
            PhoneNumber = phoneNumber;
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
