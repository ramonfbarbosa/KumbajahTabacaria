using Kumbajah.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Kumbajah.Services.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        public string Password { get; set; }
        public string? CPF { get; set; }
        public string? PhoneNumber { get; set; }
        public List<Address>? Addresses { get; }
        public List<Order>? Orders { get; }

        public UserDTO() { }

        public UserDTO(int id, string name, string lastName,
            string email, string phoneNumber, DateTime birthDate,
            string password, string cpf)
        {
            Name = name;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Birthdate = birthDate;
            Password = password;
            CPF = cpf;
            Addresses = new List<Address>();
            Orders = new List<Order>();
        }

        public UserDTO(User user)
        {
            Id = user.Id;
            Name = user.Name;
            LastName = user.LastName;
            Email = user.Email;
            PhoneNumber = user.PhoneNumber;
            Birthdate = user.Birthdate;
            Password = user.Password;
            CPF = user.CPF;
            Addresses = user.Addresses;
            Orders = user.Orders;
        }

        public User GetEntity()
        {
            return new User
            {
                Id = Id,
                Name = Name,
                LastName = LastName,
                Email = Email,
                PhoneNumber = PhoneNumber,
                Birthdate = Birthdate,
                Password = Password,
                CPF = CPF
                //Addresses = Addresses,
                //Orders = Orders
            };
        }
    }
}
