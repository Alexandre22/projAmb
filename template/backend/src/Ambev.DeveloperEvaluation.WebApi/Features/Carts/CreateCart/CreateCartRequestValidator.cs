using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Carts.CreateCart;

/// <summary>
/// Validator for the create cart request
/// </summary>
public class CreateCartRequestValidator : AbstractValidator<CreateCartRequest>
{
    /// <summary>
    /// Initializes a new instance of CreateCartRequestValidator
    /// </summary>
    public CreateCartRequestValidator()
    {
        RuleFor(x => x.UserId)
            .GreaterThan(0)
            .WithMessage("User ID must be greater than 0");

        RuleFor(x => x.Date)
            .NotEmpty()
            .WithMessage("Date is required");

        RuleFor(x => x.Products)
            .NotEmpty()
            .WithMessage("At least one product is required");

        RuleForEach(x => x.Products)
            .SetValidator(new CartItemRequestValidator());
    }
}

/// <summary>
/// Validator for the cart item request
/// </summary>
public class CartItemRequestValidator : AbstractValidator<CartItemRequest>
{
    /// <summary>
    /// Initializes a new instance of CartItemRequestValidator
    /// </summary>
    public CartItemRequestValidator()
    {
        RuleFor(x => x.ProductId)
            .GreaterThan(0)
            .WithMessage("Product ID must be greater than 0");

        RuleFor(x => x.Quantity)
            .GreaterThan(0)
            .WithMessage("Quantity must be greater than 0");
    }
}
