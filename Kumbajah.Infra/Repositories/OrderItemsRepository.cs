using Kumbajah.Domain.Entities;
using Kumbajah.Infra.Interfaces;

namespace Kumbajah.Infra.Repositories
{
    public class OrderItemsRepository : IOrderItemsRepository
    {
        public decimal SubTotal(OrderItem items)
        {
            return items.Price * items.Quantity;
        }
    }
}
