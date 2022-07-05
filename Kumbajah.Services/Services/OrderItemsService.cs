using Kumbajah.Infra.Interfaces;
using Kumbajah.Services.DTO;
using Kumbajah.Services.Interfaces;

namespace Kumbajah.Services.Services
{
    public class OrderItemsService : IOrderItemsService
    {
        public IOrderItemsRepository OrderItemsRepository { get; }

        public OrderItemsService(IOrderItemsRepository orderItemsRepository)
        {
            OrderItemsRepository = orderItemsRepository;
        }

        public decimal SubTotal(OrderItemsDTO items)
        {
            var dto = items.GetEntity();
            return OrderItemsRepository.SubTotal(dto);
        }
    }
}
