using System;

namespace Kumbajah.Services.DTO
{
    public class UserDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime Birthday { get; set; }
        public string Password { get; set; }
        public long CPF { get; set; }

        public UserDTO() { }

        public UserDTO(string name, string lastName, string email, int phoneNumber, DateTime birthday, string password, long cpf)
        {
            Name = name;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Birthday = birthday;
            Password = password;
            CPF = cpf;
        }
    }
}
