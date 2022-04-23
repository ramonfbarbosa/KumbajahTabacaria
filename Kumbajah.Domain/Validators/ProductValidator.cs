using FluentValidation;
using Kumbajah.Domain.Entities;
using System.Text.RegularExpressions;

namespace Kumbajah.Domain.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
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
                .WithMessage("O campo nome não pode ficar nulo!");

            RuleFor(costumer => costumer.Description)
                .NotEmpty()
                .WithMessage("O campo celular não pode ficar vazio!")

                .NotNull()
                .WithMessage("O campo celular não pode ficar nulo!");

            RuleFor(costumer => costumer.Price)
                .NotEmpty()
                .WithMessage("O campo Sobrenome não pode ficar vazio!")

                .NotNull()
                .WithMessage("O campo Sobrenome não pode ficar nulo!");

            RuleFor(costumer => costumer.Image)
                .NotEmpty()
                .WithMessage("O produto deve conter uma imagem!")

                .NotNull()
                .WithMessage("O produto deve conter uma imagem!");

            RuleFor(costumer => costumer.Category)
                .NotEmpty()
                .WithMessage("O produto deve conter uma categoria!")

                .NotNull()
                .WithMessage("O produto deve conter uma categoria!");
        }
    }
}
