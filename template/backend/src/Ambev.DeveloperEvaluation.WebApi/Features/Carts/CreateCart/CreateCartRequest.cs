using System.ComponentModel.DataAnnotations;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Carts.CreateCart;

/// <summary>
/// Request model for creating a new cart
/// </summary>
public class CreateCartRequest
{
    /// <summary>
    /// Gets or sets the user ID associated with this cart
    /// </summary>
    [Required]
    public int UserId { get; set; }

    /// <summary>
    /// Gets or sets the date when the cart was created
    /// </summary>
    [Required]
    public DateTime Date { get; set; }

    /// <summary>
    /// Gets or sets the collection of products in the cart
    /// </summary>
    [Required]
    public ICollection<CartItemRequest> Products { get; set; } = new List<CartItemRequest>();
}

/// <summary>
/// Request model for cart item details
/// </summary>
public class CartItemRequest
{
    /// <summary>
    /// Gets or sets the product ID
    /// </summary>
    [Required]
    public int ProductId { get; set; }

    /// <summary>
    /// Gets or sets the quantity of the product
    /// </summary>
    [Required]
    [Range(1, int.MaxValue)]
    public int Quantity { get; set; }
}
