using Kumbajah.Core.Exceptions;
using Kumbajah.Domain.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kumbajah.Domain.Entities
{
    public class Order : Base
    {
        public DateTime BuyMoment { get; set; } = DateTime.Now;
        public string PhoneNumber { get; private set; }
        public string CPF { get; private set; }
        public virtual OrderStatus OrderStatus { get; private set; }
        [Column("ORDER_STATUS_ID")]
        public int OrderStatusId { get; private set; }
        public virtual User Users { get; private set; }
        [Column("USER_ID")]
        public int UserId { get; private set; }
        public virtual Address Address { get; private set; }
        [Column("ADDRESS_ID")]
        public int AddressId { get; private set; }
        public virtual IEnumerable<OrderItem> Items { get; }

        public Order() { }

        public Order(DateTime buyMoment, string phoneNumber, 
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
            Validate();
        }

        public decimal Total()
        {
            decimal sum = 0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override bool Validate()
        {
            var validator = new OrderValidator();
            var validation = validator.Validate(this);

            if (!validation.IsValid)
            {
                foreach (var errors in validation.Errors)
                    _errors.Add(errors.ErrorMessage);

                throw new DomainException("Alguns campos estão inválidos, por favor corrija-os: ", _errors);
            }
            return true;
        }
    }
}
