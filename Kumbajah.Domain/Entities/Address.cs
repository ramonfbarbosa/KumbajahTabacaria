using System.Collections.Generic;

namespace Kumbajah.Domain.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string CEP { get; set; }
        public string Street { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public int Number { get; set; }
        public string? Complement { get; set; }
        public string Reference { get; set; }
        public virtual List<AddressUser> UserAddress { get; set; }
        public virtual Order Order { get; set; }
        public int OrderId { get; set; }

        public Address() { }

        public Address(string cep, string street, string state,
            string city, string district, int number, string reference,
            int orderId, string? complement = null)
        {
            CEP = cep;
            Street = street;
            State = state;
            City = city;
            District = district;
            Number = number;
            Reference = reference;
            Complement = complement;
            OrderId = orderId;
        }
    }
}
