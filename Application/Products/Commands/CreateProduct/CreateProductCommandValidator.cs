using FluentValidation;

namespace Application.Products.Commands.CreateProduct
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(createProductCommand => createProductCommand.Name)
                .NotEmpty()
                .MaximumLength(255);
            RuleFor(createProductCommand => createProductCommand.VendorId)
                .NotEmpty();
        }
    }
}
