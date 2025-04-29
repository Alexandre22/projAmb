namespace Ambev.DeveloperEvaluation.Application.Carts.CreateCart;

/// <summary>
/// Result returned after creating a cart
/// </summary>
public class CreateCartResult
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
    public ICollection<CartItemResult> Products { get; set; } = new List<CartItemResult>();
}

/// <summary>
/// Result for cart item details
/// </summary>
public class CartItemResult
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
