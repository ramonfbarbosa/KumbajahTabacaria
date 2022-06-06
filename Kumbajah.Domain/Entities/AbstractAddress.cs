namespace Kumbajah.Domain.Entities
{
    public abstract class AbstractAddress : Base
    {
        public string CEP { get; private set; }
        public string Street { get; private set; }
        public string State { get; private set; }
        public string City { get; private set; }
        public string District { get; private set; }
        public int Number { get; private set; }
        public string Complement { get; private set; }
        public string Reference { get; private set; }

        public AbstractAddress() { }

        public AbstractAddress(string cep, string street,
            int number, string reference, string complement) 
        {
            CEP = cep;
            Street = street;
            Number = number;
            Complement = complement;
            Reference = reference;
        }
    }
}
