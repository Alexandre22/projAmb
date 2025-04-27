using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Application.Users.GetUsers;

/// <summary>
/// Result containing a paginated list of users
/// </summary>
public class GetUsersResult
{
    /// <summary>
    /// Gets or sets the list of users for the current page
    /// </summary>
    public IEnumerable<UserDto> Data { get; set; } = new List<UserDto>();
    
    /// <summary>
    /// Gets or sets the total number of users across all pages
    /// </summary>
    public int TotalItems { get; set; }
    
    /// <summary>
    /// Gets or sets the current page number
    /// </summary>
    public int CurrentPage { get; set; }
    
    /// <summary>
    /// Gets or sets the total number of pages
    /// </summary>
    public int TotalPages { get; set; }
}

/// <summary>
/// Data transfer object for User entity
/// </summary>
public class UserDto
{
    /// <summary>
    /// Gets or sets the user's unique identifier
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Gets or sets the user's email address
    /// </summary>
    public string Email { get; set; } = string.Empty;
    
    /// <summary>
    /// Gets or sets the user's username
    /// </summary>
    public string Username { get; set; } = string.Empty;
    
    /// <summary>
    /// Gets or sets the user's password (hashed)
    /// </summary>
    public string Password { get; set; } = string.Empty;
    
    /// <summary>
    /// Gets or sets the user's name information
    /// </summary>
    public NameDto Name { get; set; } = new NameDto();
    
    /// <summary>
    /// Gets or sets the user's address information
    /// </summary>
    public AddressDto Address { get; set; } = new AddressDto();
    
    /// <summary>
    /// Gets or sets the user's phone number
    /// </summary>
    public string Phone { get; set; } = string.Empty;
    
    /// <summary>
    /// Gets or sets the user's status
    /// </summary>
    public string Status { get; set; } = string.Empty;
    
    /// <summary>
    /// Gets or sets the user's role
    /// </summary>
    public string Role { get; set; } = string.Empty;
}

/// <summary>
/// Data transfer object for UserName entity
/// </summary>
public class NameDto
{
    /// <summary>
    /// Gets or sets the user's first name
    /// </summary>
    public string Firstname { get; set; } = string.Empty;
    
    /// <summary>
    /// Gets or sets the user's last name
    /// </summary>
    public string Lastname { get; set; } = string.Empty;
}

/// <summary>
/// Data transfer object for Address entity
/// </summary>
public class AddressDto
{
    /// <summary>
    /// Gets or sets the city name
    /// </summary>
    public string City { get; set; } = string.Empty;
    
    /// <summary>
    /// Gets or sets the street name
    /// </summary>
    public string Street { get; set; } = string.Empty;
    
    /// <summary>
    /// Gets or sets the street number
    /// </summary>
    public int Number { get; set; }
    
    /// <summary>
    /// Gets or sets the postal/zip code
    /// </summary>
    public string Zipcode { get; set; } = string.Empty;
    
    /// <summary>
    /// Gets or sets the geographical coordinates
    /// </summary>
    public GeolocationDto Geolocation { get; set; } = new GeolocationDto();
}

/// <summary>
/// Data transfer object for Geolocation entity
/// </summary>
public class GeolocationDto
{
    /// <summary>
    /// Gets or sets the latitude coordinate
    /// </summary>
    public string Lat { get; set; } = string.Empty;
    
    /// <summary>
    /// Gets or sets the longitude coordinate
    /// </summary>
    public string Long { get; set; } = string.Empty;
}
