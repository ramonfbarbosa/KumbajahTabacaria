using Kumbajah.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Kumbajah.Services.DTO
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public DateTime BuyMoment { get; set; }
        public string PhoneNumber { get; set; }
        public string CPF { get; set; }
        public decimal TotalPrice { get; set; }
        public int OrderStatusId { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public List<OrderItem> Items { get; set; }

        public OrderDTO(
            int id, DateTime buyMoment, string phoneNumber,
            string cpf, decimal totalPrice, int userId, int addressId,
            int orderStatusId, List<OrderItem> items)
        {
            Id = id;
            BuyMoment = buyMoment;
            PhoneNumber = phoneNumber;
            CPF = cpf;
            TotalPrice = totalPrice;
            UserId = userId;
            AddressId = addressId;
            OrderStatusId = orderStatusId;
            Items = items;
        }

        public OrderDTO(Order order)
        {
            Id = order.Id;
            BuyMoment = order.BuyMoment;
            PhoneNumber = order.PhoneNumber;
            CPF = order.CPF;
            TotalPrice = order.TotalPrice;
            UserId = order.UserId;
            AddressId = order.AddressId;
            OrderStatusId = order.OrderStatusId;
            Items = order.Items;
        }

        public Order GetEntity()
        {
            return new Order
            {
                Id = Id,
                BuyMoment = BuyMoment,
                PhoneNumber = PhoneNumber,
                CPF = CPF,
                TotalPrice = TotalPrice,
                UserId = UserId,
                AddressId = AddressId,
                OrderStatusId = OrderStatusId,
                Items = Items
            };
        }
    }
}
