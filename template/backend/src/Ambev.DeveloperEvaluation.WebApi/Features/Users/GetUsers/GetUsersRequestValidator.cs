using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Users.GetUsers;

/// <summary>
/// Validator for GetUsersRequest
/// </summary>
public class GetUsersRequestValidator : AbstractValidator<GetUsersRequest>
{
    /// <summary>
    /// Initializes a new instance of GetUsersRequestValidator
    /// </summary>
    public GetUsersRequestValidator()
    {
        RuleFor(x => x.Page)
            .GreaterThan(0)
            .WithMessage("Page number must be greater than 0");

        RuleFor(x => x.Size)
            .GreaterThan(0)
            .LessThanOrEqualTo(50)
            .WithMessage("Page size must be between 1 and 50");
    }
}
