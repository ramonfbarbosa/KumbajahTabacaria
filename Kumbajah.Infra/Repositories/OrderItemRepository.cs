using Kumbajah.Domain.Entities;
using Kumbajah.Infra.Interfaces;

namespace Kumbajah.Infra.Repositories
{
    public class OrderItemRepository : IOrderItemsRepository
    {
        public decimal SubTotal(OrderItem items)
        {
            return items.Price * items.Quantity;
        }
    }
}
