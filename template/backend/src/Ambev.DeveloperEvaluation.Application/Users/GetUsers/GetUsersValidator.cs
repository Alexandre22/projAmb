using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Users.GetUsers;

/// <summary>
/// Validator for GetUsersQuery
/// </summary>
public class GetUsersValidator : AbstractValidator<GetUsersQuery>
{
    /// <summary>
    /// Initializes a new instance of GetUsersValidator
    /// </summary>
    public GetUsersValidator()
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
