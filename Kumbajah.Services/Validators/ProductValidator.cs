using FluentValidation;
using Kumbajah.Domain.Entities;
using Kumbajah.Infra.Interfaces;

namespace Kumbajah.Infra.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        private IProductRepository ProductRepository { get; }

        public ProductValidator(IProductRepository productRepository)
        {
            ProductRepository = productRepository;
            RuleSet("Create", () =>
            {
                RuleFor(customer => customer.Id)
                    .NotNull()
                    .WithMessage("O Id não pode ser nulo!")
                    .NotEmpty()
                    .WithMessage("O Id já existe!")
                    .Must(UniqueId)
                    .WithMessage("O Id já existe!");
            });
            RuleSet("CreateOrUpdate", () =>
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
                    .WithMessage("O campo nome não pode ficar nulo!")
                    .Must(UniqueName)
                    .WithMessage("Este produto já existe!");
                RuleFor(product => product.Description)
                    .NotEmpty()
                    .WithMessage("O campo descricao não pode ficar vazio!")
                    .NotNull()
                    .WithMessage("O campo descricao não pode ficar nulo!");
                RuleFor(product => product.Price)
                    .NotEmpty()
                    .WithMessage("O produto deve conter um preco!")
                    .NotNull()
                    .WithMessage("O produto deve conter um preco!");
                RuleFor(product => product.Image)
                    .NotEmpty()
                    .WithMessage("O produto deve conter uma imagem!")
                    .NotNull()
                    .WithMessage("O produto deve conter uma imagem!");
                RuleFor(product => product.BrandId)
                    .NotEmpty()
                    .WithMessage("O produto deve conter uma marca!")
                    .NotNull()
                    .WithMessage("O produto deve conter uma marca!");
                RuleFor(product => product.StockId)
                    .NotEmpty()
                    .WithMessage("O produto deve conter uma quantidade!")
                    .NotNull()
                    .WithMessage("O produto deve conter uma quantidade!");
                RuleFor(product => product.CategoryId)
                    .NotEmpty()
                    .WithMessage("O produto deve conter um ID da categoria!")
                    .NotNull()
                    .WithMessage("O produto deve conter um ID da categoria!");
            });
        }

        private bool UniqueId(int id) =>
            ProductRepository.GetById(id) == null;

        private bool UniqueName(string name) =>
            ProductRepository.GetByName(name) == null;
    }
}
