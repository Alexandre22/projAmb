using Ambev.DeveloperEvaluation.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProduct;

/// <summary>
/// Request model for creating a new product
/// </summary>
public class CreateProductRequest
{
    /// <summary>
    /// Gets or sets the title of the product
    /// </summary>
    [Required]
    [MaxLength(200)]
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the price of the product
    /// </summary>
    [Required]
    [Range(0.01, double.MaxValue)]
    public decimal Price { get; set; }

    /// <summary>
    /// Gets or sets the description of the product
    /// </summary>
    [Required]
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the category of the product
    /// </summary>
    [Required]
    [MaxLength(100)]
    public string Category { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the image URL of the product
    /// </summary>
    [Required]
    [Url]
    public string Image { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the rating information for the product
    /// </summary>
    [Required]
    public ProductRatingRequest Rating { get; set; } = new ProductRatingRequest();
}

/// <summary>
/// Request model for product rating
/// </summary>
public class ProductRatingRequest
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
