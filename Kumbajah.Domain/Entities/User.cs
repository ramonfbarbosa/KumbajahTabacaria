using Kumbajah.Domain.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kumbajah.Domain.Entities
{
    public class User : Base
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }

        public User() {}

        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
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
