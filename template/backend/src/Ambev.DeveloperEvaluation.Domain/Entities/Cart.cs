using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

/// <summary>
/// Represents a shopping cart in the system
/// </summary>
public class Cart
{
    /// <summary>
    /// Gets or sets the unique identifier for the cart
    /// </summary>
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

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
    /// Gets or sets the collection of cart items
    /// </summary>
    public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

    /// <summary>
    /// Gets or sets the creation date of the cart
    /// </summary>
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Gets or sets the last update date of the cart
    /// </summary>
    public DateTime? UpdatedAt { get; set; }
}
