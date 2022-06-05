using Kumbajah.Domain.Validators;
using System;
using System.Collections.Generic;

namespace Kumbajah.Domain.Entities
{
    public class Order : Base
    {
        public DateTime BuyMoment { get; set; } = DateTime.Now;
        public string PhoneNumber { get; private set; }
        public string CPF { get; private set; }
        public DateTime Birthdate { get; private set; }
        public virtual OrderStatus OrderStatus { get; private set; }
        public long OrderStatusId { get; private set; } = 1;
        public virtual User Users { get; private set; }
        public long UserId { get; private set; }
        public virtual Address Address { get; private set; }
        public long AddressId { get; private set; }
        public virtual IEnumerable<OrderItem> Items { get; }

        public Order() { }

        public Order(DateTime buyMoment, string phoneNumber, 
            string cpf, DateTime birthdate, long userId,
            long addressId)
        {
            BuyMoment = buyMoment;
            PhoneNumber = phoneNumber;
            CPF = cpf;
            Birthdate = birthdate;
            UserId = userId;
            AddressId = addressId;
            Validate();
        }

        public override bool Validate()
        {
            var validator = new OrderValidator();
            var validation = validator.Validate(this);

            if (!validation.IsValid)
            {
                foreach (var errors in validation.Errors)
                    _errors.Add(errors.ErrorMessage);

                throw new Exception("Alguns campos estão inválidos, por favor corrija-os: " + _errors[0]);
            }
            return true;
        }
    }
}
