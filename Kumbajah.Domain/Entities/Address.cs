using System.Collections.Generic;

namespace Kumbajah.Domain.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string CEP { get; private set; }
        public string Street { get; private set; }
        public string State { get; private set; }
        public string City { get; private set; }
        public string District { get; private set; }
        public int Number { get; private set; }
        public string? Complement { get; private set; }
        public string Reference { get; private set; }
        public virtual List<Order> Orders { get; }
        public virtual List<User> Users { get; }

        public Address() { }

        public Address(string cep, string street, string state,
            string city, string district, int number, string reference,
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
        }
    }
}
