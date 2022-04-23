using FluentValidation;
using Kumbajah.Domain.Entities;

namespace Kumbajah.Domain.Validators
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
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
        }
    }
}
