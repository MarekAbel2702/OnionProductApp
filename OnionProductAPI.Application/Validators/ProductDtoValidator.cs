using FluentValidation;
using OnionProductAPI.Application.DTOs;

namespace OnionProductAPI.API.Validators
{
    public class ProductDtoValidator : AbstractValidator<ProductDto>
    {
        public ProductDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Nazwa produktu jest wymagana.")
                .MaximumLength(100).WithMessage("Nazwa nie może przekraczać 100 znaków.");

            RuleFor(x => x.Description)
                .MaximumLength(500).WithMessage("Opis może mieć maksymalnie 500 znaków.");

            RuleFor(x => x.Price)
                .GreaterThan(0).WithMessage("Cena musi być większa od zera.");

            RuleFor(x => x.Quantity)
                .GreaterThanOrEqualTo(0).WithMessage("Ilość nie może być ujemna.");

            RuleFor(x => x.Category)
                .NotEmpty().WithMessage("Kategoria jest wymagana.")
                .MaximumLength(50);

            RuleFor(x => x.CreatedAt)
                .NotEmpty().WithMessage("Data utworzenia jest wymagana.");
        }
    }
}
