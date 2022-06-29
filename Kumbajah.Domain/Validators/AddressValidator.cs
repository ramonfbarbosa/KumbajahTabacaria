using FluentValidation;
using Kumbajah.Domain.Entities;
using System.Text.RegularExpressions;

namespace Kumbajah.Domain.Validators
{
    public class AddressValidator : AbstractValidator<Address>
    {
        Regex CPFRegex = new Regex(@"[0-9]{5}-[0-9]{3}");
        public AddressValidator()
        {
            RuleFor(costumer => costumer.CEP)
                .NotEmpty()
                .WithMessage("O campo e-mail não pode ficar vazio!")
                .NotNull()
                .WithMessage("O campo e-mail não pode ficar nulo!")
                .Matches(CPFRegex)
                .WithMessage("Deve ser um CPF válido");
            RuleFor(costumer => costumer.Street)
                .NotEmpty()
                .WithMessage("O campo rua não pode ficar vazio!")
                .NotNull()
                .WithMessage("O campo rua não pode ser nulo!");
            RuleFor(costumer => costumer.State)
                .NotEmpty()
                .WithMessage("O campo estado não pode ficar vazio!")
                .NotNull()
                .WithMessage("O campo estado não pode ser nulo!");
            RuleFor(costumer => costumer.City)
                .NotEmpty()
                .WithMessage("O campo cidade não pode ficar vazio!")
                .NotNull()
                .WithMessage("O campo cidade não pode ser nulo!");
            RuleFor(costumer => costumer.Number)
                .NotEmpty()
                .WithMessage("O campo número não pode ficar vazio!")
                .NotNull()
                .WithMessage("O campo número não pode ser nulo!");
            RuleFor(costumer => costumer.Reference)
                .NotEmpty()
                .WithMessage("O campo referencia não pode ficar vazio!")
                .NotNull()
                .WithMessage("O campo referencia não pode ficar nulo!");
        }
    }
}
