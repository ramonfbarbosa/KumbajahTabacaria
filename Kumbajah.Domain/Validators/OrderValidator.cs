using FluentValidation;
using Kumbajah.Domain.Entities;
using System.Text.RegularExpressions;

namespace Kumbajah.Domain.Validators
{
    public class OrderValidator : AbstractValidator<Order>
    {
        public OrderValidator()
        {
            RuleFor(costumer => costumer.PhoneNumber)
                .NotEmpty()
                .WithMessage("O campo celular não pode ficar vazio!")

                .NotNull()
                .WithMessage("O campo celular não pode ficar nulo!")

                .Matches(new Regex(@"^\([1-9]{2}\) (?:[2-8]|9[1-9])[0-9]{3}\-[0-9]{4}$"))
                .WithMessage("Celular inválido! Coloque o DDD na frente e 9 numeros");
            
            RuleFor(costumer => costumer.CPF)
                .NotEmpty()
                .WithMessage("O campo e-mail não pode ficar vazio!")

                .NotNull()
                .WithMessage("O campo e-mail não pode ficar nulo!")

                .Matches(new Regex(@"[0-9]{3}\.?[0-9]{3}\.?[0-9]{3}\-?[0-9]{2}"))
                .WithMessage("Deve ser um CPF válido");
        }
    }
}
