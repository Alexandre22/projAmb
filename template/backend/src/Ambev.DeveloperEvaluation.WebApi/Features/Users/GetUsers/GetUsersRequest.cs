using Microsoft.AspNetCore.Mvc;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Users.GetUsers;

/// <summary>
/// Request model for retrieving a paginated list of users
/// </summary>
public class GetUsersRequest
{
    /// <summary>
    /// Gets or sets the page number (1-based)
    /// </summary>
    [FromQuery(Name = "_page")]
    public int Page { get; set; } = 1;
    
    /// <summary>
    /// Gets or sets the page size (number of items per page)
    /// </summary>
    [FromQuery(Name = "_size")]
    public int Size { get; set; } = 10;
    
    /// <summary>
    /// Gets or sets the ordering expression (e.g., "username asc, email desc")
    /// </summary>
    [FromQuery(Name = "_order")]
    public string? Order { get; set; }
}
