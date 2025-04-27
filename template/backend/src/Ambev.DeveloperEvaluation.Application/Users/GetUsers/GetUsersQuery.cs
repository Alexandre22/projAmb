using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Users.GetUsers;

/// <summary>
/// Query to retrieve a paginated list of users
/// </summary>
public class GetUsersQuery : IRequest<GetUsersResult>
{
    /// <summary>
    /// Gets or sets the page number (1-based)
    /// </summary>
    public int Page { get; set; } = 1;
    
    /// <summary>
    /// Gets or sets the page size (number of items per page)
    /// </summary>
    public int Size { get; set; } = 10;
    
    /// <summary>
    /// Gets or sets the ordering expression (e.g., "username asc, email desc")
    /// </summary>
    public string? Order { get; set; }
}
