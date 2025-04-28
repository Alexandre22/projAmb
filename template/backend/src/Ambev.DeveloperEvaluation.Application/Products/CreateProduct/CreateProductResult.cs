using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Products.CreateProduct;

/// <summary>
/// Result returned after creating a product
/// </summary>
public class CreateProductResult
{
    /// <summary>
    /// Gets or sets the unique identifier for the product
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the title of the product
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the price of the product
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Gets or sets the description of the product
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the category of the product
    /// </summary>
    public string Category { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the image URL of the product
    /// </summary>
    public string Image { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the rating information for the product
    /// </summary>
    public ProductRating Rating { get; set; } = new ProductRating();
}
