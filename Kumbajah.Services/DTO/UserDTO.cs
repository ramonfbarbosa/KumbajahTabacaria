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
        public List<AddressUser>? UserAddress { get; }
        public List<Order>? Orders { get; set; }

        public UserDTO(
            int id, string name, string lastName,
            string email, string phoneNumber,
            DateTime birthDate, string password, string cpf)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Birthdate = birthDate;
            Password = password;
            CPF = cpf;
            UserAddress = new List<AddressUser>();
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
            UserAddress = user.UserAddress;
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
                CPF = CPF,
                UserAddress = UserAddress,
                Orders = Orders
            };
        }
    }
}
