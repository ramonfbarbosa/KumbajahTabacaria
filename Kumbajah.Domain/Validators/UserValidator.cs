using FluentValidation;
using Kumbajah.Domain.Entities;
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

            RuleFor(costumer => costumer.PhoneNumber)
                .NotEmpty()
                .WithMessage("O campo celular não pode ficar vazio!")

                .NotNull()
                .WithMessage("O campo celular não pode ficar nulo!");

            _ = RuleFor(costumer => costumer.LastName)
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

                //pode da merda isso daqui de 2 validacoes
                .EmailAddress()
                .WithMessage("O e-mail precisa ser válido!")

                .Matches(new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
                .WithMessage("O e-mail informado não é válido!");
        }
    }
}
