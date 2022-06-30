using FluentValidation;
using Kumbajah.Domain.Entities;
using Kumbajah.Infra.Interfaces;
using Kumbajah.Services.DTO;
using Kumbajah.Services.Interfaces;
using KumbajahTabacaria.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kumbajah.Services.Services
{
    public class OrderService : IOrderService
    {
        private IOrderRepository OrderRepository { get; }
        private IValidator<Order> Validator { get; }

        public OrderService(IOrderRepository orderRepository, 
            IValidator<Order> validator)
        {
            OrderRepository = orderRepository;
            Validator = validator;
        }

        public OrderDTO GetById(int id)
        {
            var entity = OrderRepository.GetById(id);
            return new OrderDTO(entity);
        }

        public List<OrderDTO> GetAll()
        {
            var allOrders = OrderRepository.GetAll();
            var dtos = new List<OrderDTO>();
            foreach (var order in allOrders)
            {
                var dto = new OrderDTO(order.Id, order.BuyMoment,
                    order.PhoneNumber, order.CPF, order.UserId,
                    order.AddressId, order.OrderStatusId, order.Items);
                dtos.Add(dto);
            }
            return dtos;
        }

        public async Task<ValidationResponse<OrderDTO>> Create(OrderDTO orderDTO)
        {
            var order = orderDTO.GetEntity();
            var validationResult = Validator.Validate(order, o => o.IncludeRuleSets("CreateOrUpdate", "Create"));
            if (validationResult.IsValid)
            {
                var entity = await OrderRepository.Create(order);
                var dto = new OrderDTO(entity);
                return ValidationResponse<OrderDTO>.Valid(validationResult, dto);
            }
            else
            {
                return ValidationResponse<OrderDTO>.Invalid(validationResult);
            }
        }        
    }
}
