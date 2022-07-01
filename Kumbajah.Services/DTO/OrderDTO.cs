﻿using Kumbajah.Domain.Entities;
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
        public int OrderStatusId { get; set; }
        public int UserId { get; set; }
        public int AddressId { get; set; }
        public List<OrderItem> Items { get; set; }

        public OrderDTO() { }

        public OrderDTO(int id, DateTime buyMoment, string phoneNumber,
            string cpf, int userId, int addressId, int orderStatusId,
            List<OrderItem> items)
        {
            Id = id;
            BuyMoment = buyMoment;
            PhoneNumber = phoneNumber;
            CPF = cpf;
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
                UserId = UserId,
                AddressId = AddressId,
                OrderStatusId = OrderStatusId,
                Items = Items
            };
        }
    }
}
