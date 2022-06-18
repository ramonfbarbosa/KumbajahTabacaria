using FluentValidation;
using Kumbajah.Domain.Entities;
using System.Text.RegularExpressions;

namespace Kumbajah.Domain.Validators
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(costumer => costumer.CEP)
                .NotEmpty()
                .WithMessage("O campo e-mail não pode ficar vazio!")

                .NotNull()
                .WithMessage("O campo e-mail não pode ficar nulo!")
                
                .Matches(new Regex(@"[0-9]{5}-[0-9]{3}"))
                .WithMessage("Deve ser um CPF válido");

            RuleFor(costumer => costumer.Street)
                .NotEmpty()
                .WithMessage("O campo e-mail não pode ficar vazio!")

                .NotNull()
                .WithMessage("O campo e-mail não pode ficar nulo!")

                .Matches(new Regex(@"[0-9]{3}\.?[0-9]{3}\.?[0-9]{3}\-?[0-9]{2}"))
                .WithMessage("Deve ser um CPF válido");

            RuleFor(costumer => costumer.Number)
                .NotEmpty()
                .WithMessage("O campo e-mail não pode ficar vazio!")

                .NotNull()
                .WithMessage("O campo e-mail não pode ficar nulo!");

            RuleFor(costumer => costumer.Reference)
                .NotEmpty()
                .WithMessage("O campo e-mail não pode ficar vazio!")

                .NotNull()
                .WithMessage("O campo e-mail não pode ficar nulo!");
        }
    }
}
