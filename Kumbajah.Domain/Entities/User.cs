using System;
using System.Collections.Generic;

namespace Kumbajah.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        public string Password { get; set; }
        public string? CPF { get; set; }
        public string? PhoneNumber { get; set; }
        public virtual List<AddressUser>? UserAddress { get; set; }
        public virtual List<Order>? Orders { get; set; }

        public User() { }

        public User(int id, string name, string lastName, string email, 
            DateTime birthdate, string password,
            string? cpf = null, string? phoneNumber = null)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Birthdate = birthdate;
            Password = password;
            CPF = cpf;
            Orders = new List<Order>();
        }
    }
}
