using FluentValidation;
using Kumbajah.Domain.Entities;
using Kumbajah.Infra.Interfaces;
using Kumbajah.Services.DTO;
using Kumbajah.Services.Interfaces;
using KumbajahTabacaria.Response;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kumbajah.Services.Services
{
    public class OrderService : IOrderService
    {
        private const int OrderStatusPaid = 1;
        private IOrderRepository OrderRepository { get; }
        public IUserRepository UserRepository { get; set; }
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

        public async Task<ValidationResponse<OrderDTO>> CreateAsync(OrderDTO orderDTO)
        {
            var order = orderDTO.GetEntity();
            CreateResource(order);
            var validationResult = Validator.Validate(order);
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

        private void CreateResource(Order order)
        {
            var user = UserRepository.GetById(order.UserId);
            order.BuyMoment = DateTime.Now;
            order.OrderStatusId = OrderStatusPaid;
            user.PhoneNumber = order.PhoneNumber;
            user.CPF = order.CPF;
            user = order.User;
            user.Orders.Add(order);
        }
    }
}
