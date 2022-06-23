﻿using Kumbajah.Core.Exceptions;
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
        public string ConfirmPassword { get; private set; }// ns oq fazer c isso
        public string? CPF { get; private set; }
        public string? PhoneNumber { get; private set; }
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
