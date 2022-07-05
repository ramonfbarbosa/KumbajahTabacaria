using Kumbajah.Services.DTO;

namespace Kumbajah.Services.Interfaces
{
    public interface IOrderItemsService
    {
        decimal SubTotal(OrderItemsDTO items);
    }
}
