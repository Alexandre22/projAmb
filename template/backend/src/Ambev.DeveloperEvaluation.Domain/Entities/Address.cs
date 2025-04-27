namespace Ambev.DeveloperEvaluation.Domain.Entities;

/// <summary>
/// Represents a physical address with location details
/// </summary>
public class Address
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
    public Geolocation Geolocation { get; set; } = new Geolocation();
}
