using FluentValidation;
using Kumbajah.Domain.Entities;
using System;
using System.Linq;

namespace Kumbajah.Domain.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(costumer => costumer)
                .NotEmpty()
                .WithMessage("A entidade não pode ser vazia")
                .NotNull()
                .WithMessage("A entidade não pode ser nula");
            RuleFor(costumer => costumer.Name)
                .NotEmpty()
                .WithMessage("O campo nome não pode ficar vazio!")
                .NotNull()
                .WithMessage("O campo nome não pode ficar nulo!")
                .MinimumLength(2)
                .WithMessage("O nome deve ter no mínimo 2 caracteres")
                .MaximumLength(80)
                .WithMessage("O nome deve ter no máximo 80 caracteres");
            RuleFor(costumer => costumer.LastName)
                .NotEmpty()
                .WithMessage("O campo sobrenome não pode ficar vazio!")
                .NotNull()
                .WithMessage("O campo sobrenome não pode ficar nulo!")
                .MinimumLength(3)
                .WithMessage("O nome deve ter no mínimo 2 caracteres")
                .MaximumLength(80)
                .WithMessage("O nome deve ter no máximo 80 caracteres");
            RuleFor(costumer => costumer.Email)
                .NotEmpty()
                .WithMessage("O campo e-mail não pode ficar vazio!")
                .NotNull()
                .WithMessage("O campo e-mail não pode ficar nulo!")
                .MinimumLength(10)
                .WithMessage("O email deve ter no mínimo 10 caracteres")
                .MaximumLength(80)
                .WithMessage("O nome deve ter no máximo 80 caracteres")
                .EmailAddress()
                .WithMessage("O e-mail precisa ser válido!");
            RuleFor(costumer => costumer.Birthdate)
                .NotEmpty()
                .WithMessage("O campo e-mail não pode ficar vazio!")
                .NotNull()
                .WithMessage("O campo e-mail não pode ficar nulo!")
                .Must(BeOver18)
                .WithMessage("Voce precisa ter mais de 18 anos!");
            RuleFor(costumer => costumer.Password)
                .NotEmpty()
                .WithMessage("O campo e-mail não pode ficar vazio!")
                .NotNull()
                .WithMessage("O campo e-mail não pode ficar nulo!")
                .Must(HasValidPassword)
                .WithMessage("A senha deve conter letras maiusculas e minusculas, caracter especial e numeros");
        }

        private bool BeOver18(DateTime birthdate)
        {
            var today = DateTime.Now;
            var age = today.Year - birthdate.Year;
            if (birthdate.Date > today.AddYears(-age))
                age--;
            if (age >= 18)
            {
                return true;
            }
            return false;
        }

        private bool HasValidPassword(string password)
        {
            bool hasDigit = password.Any(char.IsDigit);
            bool hasSymbol = password.Any(char.IsSymbol);
            bool hasUpper = password.Any(char.IsUpper);
            bool hasLower = password.Any(char.IsLower);
            bool hasNumber = password.Any(char.IsNumber);
            if (hasDigit &&
                hasSymbol &&
                hasUpper &&
                hasLower &&
                hasNumber)
                return true;
            return false;
        }
    }
}
