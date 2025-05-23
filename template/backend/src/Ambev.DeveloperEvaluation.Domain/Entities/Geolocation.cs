namespace Ambev.DeveloperEvaluation.Domain.Entities;

/// <summary>
/// Represents geographical coordinates with latitude and longitude
/// </summary>
public class Geolocation
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
