namespace Kumbajah.Domain.Entities
{
    public class AddressUser
    {
        public int Id { get; set; }
        public virtual User User { get; set; }
        public int UserId { get; set; }
        public virtual Address Address { get; set; }
        public int AddressId { get; set; }

        public AddressUser() { }

        public AddressUser(int id, int userId, int addressId)
        {
            Id = id;
            UserId = userId;
            AddressId = addressId;
        }
    }
}
