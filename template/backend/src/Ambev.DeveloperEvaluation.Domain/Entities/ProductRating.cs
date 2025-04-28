using System.ComponentModel.DataAnnotations;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

/// <summary>
/// Represents a product rating with rate and count
/// </summary>
public class ProductRating
{
    /// <summary>
    /// Gets or sets the rating value
    /// </summary>
    [Range(0, 5)]
    public decimal Rate { get; set; }

    /// <summary>
    /// Gets or sets the number of ratings
    /// </summary>
    [Range(0, int.MaxValue)]
    public int Count { get; set; }
}
