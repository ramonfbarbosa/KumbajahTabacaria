using System.Collections.Generic;

namespace Kumbajah.Domain.Entities
{
    public class OrderStatus
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public virtual IEnumerable<Order> Orders { get; private set; }

        public OrderStatus() { }

        public OrderStatus(string status)
        {
            Status = status;
        }
    }
}
