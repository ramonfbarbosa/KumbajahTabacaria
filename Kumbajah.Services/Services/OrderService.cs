using AutoMapper;
using Kumbajah.Core.Exceptions;
using Kumbajah.Domain.Entities;
using Kumbajah.Infra.Interfaces;
using Kumbajah.Services.DTO;
using Kumbajah.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kumbajah.Services.Services
{
    public class OrderService : IOrderService
    {
        private IMapper Mapper { get; }
        private IOrderRepository OrderRepository { get; }

        public OrderService(IMapper mapper, IOrderRepository orderRepository)
        {
            Mapper = mapper;
            OrderRepository = orderRepository;
        }

        public async Task<OrderDTO> Create(OrderDTO orderDTO)
        {
            var order = Mapper.Map<Order>(orderDTO);
            order.Validate();
            var creaatedOrder = await OrderRepository.Create(order);
            return Mapper.Map<OrderDTO>(creaatedOrder);
        }

        public async Task Remove(long id)
        {
            await OrderRepository.Delete(id);
        }

        public async Task<List<OrderDTO>> GetAll()
        {
            var allProducts = await OrderRepository.Get();
            return Mapper.Map<List<OrderDTO>>(allProducts);
        }

        public async Task<OrderDTO> GetById(long id)
        {
            var order = await OrderRepository.GetById(id);
            return Mapper.Map<OrderDTO>(order);
        }

        public async Task<OrderDTO> Update(OrderDTO orderDTO)
        {
            var existingOrder = await OrderRepository.GetById(orderDTO.);
            if (existingOrder != null)
                throw new DomainException("Não existe nenhum pedido com este Id");
            var order = Mapper.Map<Order>(existingOrder);
            var updatedOrder = await OrderRepository.Update(order);
            return Mapper.Map<OrderDTO>(updatedOrder);
        }
    }
}
