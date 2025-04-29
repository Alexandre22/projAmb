namespace Ambev.DeveloperEvaluation.WebApi.Features.Carts.CreateCart;

/// <summary>
/// Response model for created cart
/// </summary>
public class CreateCartResponse
{
    /// <summary>
    /// Gets or sets the unique identifier for the cart
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the user ID associated with this cart
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// Gets or sets the date when the cart was created
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// Gets or sets the collection of products in the cart
    /// </summary>
    public ICollection<CartItemResponse> Products { get; set; } = new List<CartItemResponse>();
}

/// <summary>
/// Response model for cart item details
/// </summary>
public class CartItemResponse
{
    /// <summary>
    /// Gets or sets the product ID
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Gets or sets the quantity of the product
    /// </summary>
    public int Quantity { get; set; }
}
