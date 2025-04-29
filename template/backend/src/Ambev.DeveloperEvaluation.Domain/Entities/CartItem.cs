using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

/// <summary>
/// Represents an item in a shopping cart
/// </summary>
public class CartItem
{
    /// <summary>
    /// Gets or sets the unique identifier for the cart item
    /// </summary>
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the product ID
    /// </summary>
    [Required]
    public int ProductId { get; set; }

    /// <summary>
    /// Gets or sets the product associated with this cart item
    /// </summary>
    [ForeignKey("ProductId")]
    public Product? Product { get; set; }

    /// <summary>
    /// Gets or sets the quantity of the product
    /// </summary>
    [Required]
    [Range(1, int.MaxValue)]
    public int Quantity { get; set; }

    /// <summary>
    /// Gets or sets the cart ID this item belongs to
    /// </summary>
    public int CartId { get; set; }

    /// <summary>
    /// Gets or sets the cart this item belongs to
    /// </summary>
    [ForeignKey("CartId")]
    public Cart? Cart { get; set; }
}
