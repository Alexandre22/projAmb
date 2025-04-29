using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Repositories;

/// <summary>
/// Repository interface for cart operations
/// </summary>
public interface ICartRepository
{
    /// <summary>
    /// Creates a new cart
    /// </summary>
    /// <param name="cart">The cart to create</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created cart</returns>
    Task<Cart> CreateCartAsync(Cart cart, CancellationToken cancellationToken);

    /// <summary>
    /// Gets a cart by its ID
    /// </summary>
    /// <param name="id">The cart ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The cart if found, null otherwise</returns>
    Task<Cart?> GetCartByIdAsync(int id, CancellationToken cancellationToken);

    /// <summary>
    /// Gets all carts for a specific user
    /// </summary>
    /// <param name="userId">The user ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A collection of carts</returns>
    Task<IEnumerable<Cart>> GetCartsByUserIdAsync(int userId, CancellationToken cancellationToken);

    /// <summary>
    /// Updates an existing cart
    /// </summary>
    /// <param name="cart">The cart to update</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The updated cart</returns>
    Task<Cart> UpdateCartAsync(Cart cart, CancellationToken cancellationToken);

    /// <summary>
    /// Deletes a cart
    /// </summary>
    /// <param name="id">The cart ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if deleted, false otherwise</returns>
    Task<bool> DeleteCartAsync(int id, CancellationToken cancellationToken);
}
