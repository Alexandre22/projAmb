using Ambev.DeveloperEvaluation.Domain.Entities;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Carts.CreateCart;

/// <summary>
/// Command to create a new cart
/// </summary>
public class CreateCartCommand : IRequest<CreateCartResult>
{
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
    public ICollection<CartItemCommand> Products { get; set; } = new List<CartItemCommand>();
}

/// <summary>
/// Command for cart item details
/// </summary>
public class CartItemCommand
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
