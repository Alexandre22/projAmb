using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProduct;

/// <summary>
/// Validator for CreateProductRequest
/// </summary>
public class CreateProductRequestValidator : AbstractValidator<CreateProductRequest>
{
    /// <summary>
    /// Initializes a new instance of CreateProductRequestValidator
    /// </summary>
    public CreateProductRequestValidator()
    {
        RuleFor(x => x.Title)
            .NotEmpty().WithMessage("Title is required")
            .MaximumLength(200).WithMessage("Title cannot exceed 200 characters");

        RuleFor(x => x.Price)
            .GreaterThan(0).WithMessage("Price must be greater than zero");

        RuleFor(x => x.Description)
            .NotEmpty().WithMessage("Description is required");

        RuleFor(x => x.Category)
            .NotEmpty().WithMessage("Category is required")
            .MaximumLength(100).WithMessage("Category cannot exceed 100 characters");

        RuleFor(x => x.Image)
            .NotEmpty().WithMessage("Image URL is required")
            .Must(uri => Uri.TryCreate(uri, UriKind.Absolute, out _))
            .WithMessage("Image must be a valid URL");

        RuleFor(x => x.Rating).SetValidator(new ProductRatingRequestValidator());
    }
}

/// <summary>
/// Validator for ProductRatingRequest
/// </summary>
public class ProductRatingRequestValidator : AbstractValidator<ProductRatingRequest>
{
    /// <summary>
    /// Initializes a new instance of ProductRatingRequestValidator
    /// </summary>
    public ProductRatingRequestValidator()
    {
        RuleFor(x => x.Rate)
            .InclusiveBetween(0, 5).WithMessage("Rate must be between 0 and 5");

        RuleFor(x => x.Count)
            .GreaterThanOrEqualTo(0).WithMessage("Count must be a non-negative number");
    }
}
