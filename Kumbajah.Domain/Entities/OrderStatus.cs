using System.Collections.Generic;

namespace Kumbajah.Domain.Entities
{
    public class OrderStatus
    {
        public short Id { get; set; }
        public string Name { get; set; }
        public virtual IEnumerable<Order> Orders { get; private set; }

        public OrderStatus() { }

        public OrderStatus(string name)
        {
            Name = name;
        }
    }
}
