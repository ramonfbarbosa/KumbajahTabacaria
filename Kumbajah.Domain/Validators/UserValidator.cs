using FluentValidation;
using Kumbajah.Domain.Entities;
using System;
using System.Text.RegularExpressions;

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
                
                .MinimumLength(3)
                .WithMessage("O nome deve ter no mínimo 3 caracteres")
                
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

            RuleFor(costumer => costumer.PhoneNumber)
                .NotEmpty()
                .WithMessage("O campo celular não pode ficar vazio!")

                .NotNull()
                .WithMessage("O campo celular não pode ficar nulo!")
                
                .Matches(new Regex(@"^\([1-9]{2}\) (?:[2-8]|9[1-9])[0-9]{3}\-[0-9]{4}$"))
                .WithMessage("Celular invãlido! Coloque o DDD na frente");

            RuleFor(costumer => costumer.Birthday)
                .NotEmpty()
                .WithMessage("O campo e-mail não pode ficar vazio!")

                .NotNull()
                .WithMessage("O campo e-mail não pode ficar nulo!")

                .Must(x => BeOver18(x))
                .WithMessage("Voce precisa ter mais de 18 anos!");

            RuleFor(costumer => costumer.Password)
                .NotEmpty()
                .WithMessage("O campo e-mail não pode ficar vazio!")

                .NotNull()
                .WithMessage("O campo e-mail não pode ficar nulo!")

                .Must(x => HasValidPassword(x))
                .WithMessage("A senha deve conter letras maiusculas e minusculas, caracter especial e numeros");

            RuleFor(costumer => costumer.ConfirmPassword)
                 .NotEmpty()
                .WithMessage("O campo e-mail não pode ficar vazio!")

                .NotNull()
                .WithMessage("O campo e-mail não pode ficar nulo!")

                .Equal(x => x.Password)
                .WithMessage("As senhas nao batem!");

            RuleFor(costumer => costumer.CPF)
               .NotEmpty()
               .WithMessage("O campo e-mail não pode ficar vazio!")

               .NotNull()
               .WithMessage("O campo e-mail não pode ficar nulo!")

               .Matches(new Regex(@"[0-9]{3}\.?[0-9]{3}\.?[0-9]{3}\-?[0-9]{2}"))
               .WithMessage("Deve ser um CPF válido");

        }
        protected static bool BeOver18(DateTime userBday)
        {
            int eighteen = 18;
            var today = DateTime.Today;
            int age = today.Year - userBday.Year;
            if (age >= eighteen)
                return true;
            return false;
        }
        private static bool HasValidPassword(string pw)
        {
            var lowercase = new Regex("[a-z]+");
            var uppercase = new Regex("[A-Z]+");
            var digit = new Regex("(\\d)+");
            var symbol = new Regex("(\\W)+");

            return (lowercase.IsMatch(pw) &&
                uppercase.IsMatch(pw) &&
                digit.IsMatch(pw) &&
                symbol.IsMatch(pw));
        }
    }
}
