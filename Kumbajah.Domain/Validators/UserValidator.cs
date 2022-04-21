using FluentValidation;
using Kumbajah.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                .WithMessage("A entidade não pode ser vazia")

                .NotNull()
                .WithMessage("A entidade não pode ser nula")
                
                .MinimumLength(3)
                .WithMessage("O nome deve ter no mínimo 3 caracteres")
                
                .MaximumLength(80)
                .WithMessage("O nome deve ter no máximo 80 caracteres");

            RuleFor(costumer => costumer.Email)
                .NotEmpty()
                .WithMessage("A entidade não pode ser vazia")

                .NotNull()
                .WithMessage("A entidade não pode ser nula")

                .MinimumLength(10)
                .WithMessage("O email deve ter no mínimo 10 caracteres")

                .MaximumLength(80)
                .WithMessage("O nome deve ter no máximo 80 caracteres")

                //pode da merda isso daqui de 2 validacoes
                .EmailAddress()
                .WithMessage("O email precisa ser válido")

                .Matches(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
                .WithMessage("O email informado não é válido.");


        }
    }
}
