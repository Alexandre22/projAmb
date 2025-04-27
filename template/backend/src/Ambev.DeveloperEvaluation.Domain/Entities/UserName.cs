using System;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

/// <summary>
/// Represents a user's full name with first and last name components
/// </summary>
public class UserName
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
