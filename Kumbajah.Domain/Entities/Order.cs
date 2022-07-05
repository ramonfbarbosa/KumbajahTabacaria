using System;
using System.Collections.Generic;

namespace Kumbajah.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime BuyMoment { get; set; }
        public string PhoneNumber { get; set; }
        public string CPF { get; set; }
        public decimal TotalPrice { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }
        public int OrderStatusId { get; set; }
        public virtual User User { get; set; }
        public int UserId { get; set; }
        public virtual Address Address { get; set; }
        public int AddressId { get; set; }
        public virtual List<OrderItem> Items { get; set; }

        public Order() { }

        public Order(
            DateTime buyMoment, string phoneNumber,
            string cpf, int userId, int addressId,
            int orderStatusId, List<OrderItem> items)
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
