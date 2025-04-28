namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProduct;

/// <summary>
/// Response model for created product
/// </summary>
public class CreateProductResponse
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
    public ProductRatingResponse Rating { get; set; } = new ProductRatingResponse();
}

/// <summary>
/// Response model for product rating
/// </summary>
public class ProductRatingResponse
{
    /// <summary>
    /// Gets or sets the rating value
    /// </summary>
    public decimal Rate { get; set; }

    /// <summary>
    /// Gets or sets the number of ratings
    /// </summary>
    public int Count { get; set; }
}
