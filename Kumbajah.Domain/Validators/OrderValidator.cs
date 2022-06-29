using FluentValidation;
using Kumbajah.Domain.Entities;
using System.Text.RegularExpressions;

namespace Kumbajah.Domain.Validators
{
    public class OrderValidator : AbstractValidator<Order>
    {
        Regex PhoneNumberRegex = new(@"^\([1-9]{2}\) (?:[2-8]|9[1-9])[0-9]{3}\-[0-9]{4}$");
        public OrderValidator()
        {
            RuleFor(costumer => costumer.PhoneNumber)
                .NotEmpty()
                .WithMessage("O campo celular não pode ficar vazio!")
                .NotNull()
                .WithMessage("O campo celular não pode ser nulo!")
                .Matches(new Regex(@"^\([1-9]{2}\) (?:[2-8]|9[1-9])[0-9]{3}\-[0-9]{4}$"))
                .WithMessage("Celular inválido! Coloque o DDD na frente e 9 números!");
            RuleFor(costumer => costumer.CPF)
                .NotEmpty()
                .WithMessage("O campo CPF não pode ficar vazio!")
                .NotNull()
                .WithMessage("O campo CPF não pode ser nulo!")
                .Matches(PhoneNumberRegex)
                .WithMessage("Deve ser um CPF válido");
            RuleFor(costumer => costumer.OrderStatusId)
                .NotEmpty()
                .WithMessage("O campo OrderStatus não pode ficar vazio!")
                .NotNull()
                .WithMessage("O campo OrderStatus não pode ser nulo!");
            RuleFor(costumer => costumer.UserId)
                .NotEmpty()
                .WithMessage("O campo User não pode ficar vazio!")
                .NotNull()
                .WithMessage("O campo User não pode ser nulo!");
            RuleFor(costumer => costumer.AddressId)
               .NotEmpty()
               .WithMessage("O campo Endereco não pode ficar vazio!")
               .NotNull()
               .WithMessage("O campo Endereco não pode ser nulo!");
        }
    }
}
