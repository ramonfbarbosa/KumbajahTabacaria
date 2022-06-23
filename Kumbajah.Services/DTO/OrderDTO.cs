﻿using Kumbajah.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Kumbajah.Services.DTO
{
    public class OrderDTO
    {
        public DateTime BuyMoment { get; set; } = DateTime.Now;
        public string PhoneNumber { get; private set; }
        public string CPF { get; private set; }
        public int OrderStatusId { get; private set; }
        public int UserId { get; private set; }
        public int AddressId { get; private set; }
        public virtual IEnumerable<OrderItem> Items { get; }

        public OrderDTO() { }

        public OrderDTO(DateTime buyMoment, string phoneNumber,
            string cpf, int userId, int addressId, int orderStatusId,
            IEnumerable<OrderItem> items)
        {
            BuyMoment = buyMoment;
            PhoneNumber = phoneNumber;
            CPF = cpf;
            UserId = userId;
            AddressId = addressId;
            OrderStatusId = orderStatusId;
            Items = items;
        }
    }
}
