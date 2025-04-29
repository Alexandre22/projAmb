using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.ORM.Repositories;

/// <summary>
/// Repository implementation for cart operations
/// </summary>
public class CartRepository : ICartRepository
{
    private readonly DefaultContext _dbContext;

    /// <summary>
    /// Initializes a new instance of CartRepository
    /// </summary>
    /// <param name="dbContext">The database context</param>
    public CartRepository(DefaultContext dbContext)
    {
        _dbContext = dbContext;
    }

    /// <summary>
    /// Creates a new cart
    /// </summary>
    /// <param name="cart">The cart to create</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created cart</returns>
    public async Task<Cart> CreateCartAsync(Cart cart, CancellationToken cancellationToken)
    {
        await _dbContext.Carts.AddAsync(cart, cancellationToken);
        await _dbContext.SaveChangesAsync(cancellationToken);
        return cart;
    }

    /// <summary>
    /// Gets a cart by its ID
    /// </summary>
    /// <param name="id">The cart ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The cart if found, null otherwise</returns>
    public async Task<Cart?> GetCartByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await _dbContext.Carts
            .Include(c => c.CartItems)
            .FirstOrDefaultAsync(c => c.Id == id, cancellationToken);
    }

    /// <summary>
    /// Gets all carts for a specific user
    /// </summary>
    /// <param name="userId">The user ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A collection of carts</returns>
    public async Task<IEnumerable<Cart>> GetCartsByUserIdAsync(int userId, CancellationToken cancellationToken)
    {
        return await _dbContext.Carts
            .Include(c => c.CartItems)
            .Where(c => c.UserId == userId)
            .ToListAsync(cancellationToken);
    }

    /// <summary>
    /// Updates an existing cart
    /// </summary>
    /// <param name="cart">The cart to update</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The updated cart</returns>
    public async Task<Cart> UpdateCartAsync(Cart cart, CancellationToken cancellationToken)
    {
        cart.UpdatedAt = DateTime.UtcNow;
        _dbContext.Carts.Update(cart);
        await _dbContext.SaveChangesAsync(cancellationToken);
        return cart;
    }

    /// <summary>
    /// Deletes a cart
    /// </summary>
    /// <param name="id">The cart ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if deleted, false otherwise</returns>
    public async Task<bool> DeleteCartAsync(int id, CancellationToken cancellationToken)
    {
        var cart = await _dbContext.Carts.FindAsync(new object[] { id }, cancellationToken);
        if (cart == null)
            return false;

        _dbContext.Carts.Remove(cart);
        await _dbContext.SaveChangesAsync(cancellationToken);
        return true;
    }
}
