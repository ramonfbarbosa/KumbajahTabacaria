using FluentValidation;
using Kumbajah.Domain.Entities;

namespace Kumbajah.Domain.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(product => product)
                .NotEmpty()
                .WithMessage("A entidade não pode ser vazia")
                
                .NotNull()
                .WithMessage("A entidade não pode ser nula");

            RuleFor(product => product.Name)
                .NotEmpty()
                .WithMessage("O campo nome não pode ficar vazio!")

                .NotNull()
                .WithMessage("O campo nome não pode ficar nulo!");

            RuleFor(product => product.Description)
                .NotEmpty()
                .WithMessage("O campo descricao não pode ficar vazio!")

                .NotNull()
                .WithMessage("O campo descricao não pode ficar nulo!");

            RuleFor(product => product.Price)
                .NotEmpty()
                .WithMessage("O campo preco não pode ficar vazio!")

                .NotNull()
                .WithMessage("O campo preco não pode ficar nulo!");

            RuleFor(product => product.Image)
                .NotEmpty()
                .WithMessage("O produto deve conter uma imagem!")

                .NotNull()
                .WithMessage("O produto deve conter uma imagem!");

            RuleFor(product => product.Brand)
                .NotEmpty()
                .WithMessage("O produto deve conter uma marca!")

                .NotNull()
                .WithMessage("O produto deve conter uma marca!");

            RuleFor(product => product.Quantity)
                .NotEmpty()
                .WithMessage("O produto deve conter uma quantidade!")

                .NotNull()
                .WithMessage("O produto deve conter uma quantidade!");

            RuleFor(product => product.CategoryId)
                .NotEmpty()
                .WithMessage("O produto deve conter um ID da categoria!")

                .NotNull()
                .WithMessage("O produto deve conter um ID da categoria!");
        }
    }
}
