using Kumbajah.Domain.Entities;

namespace Kumbajah.Infra.Interfaces
{
    public interface IOrderItemsRepository
    {
        decimal SubTotal(OrderItem items);
    }
}
