using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Carts.CreateCart;

/// <summary>
/// Handler for creating a new cart
/// </summary>
public class CreateCartHandler : IRequestHandler<CreateCartCommand, CreateCartResult>
{
    private readonly ICartRepository _cartRepository;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of CreateCartHandler
    /// </summary>
    /// <param name="cartRepository">The cart repository</param>
    /// <param name="mapper">The AutoMapper instance</param>
    public CreateCartHandler(ICartRepository cartRepository, IMapper mapper)
    {
        _cartRepository = cartRepository;
        _mapper = mapper;
    }

    /// <summary>
    /// Handles the create cart command
    /// </summary>
    /// <param name="request">The create cart command</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created cart result</returns>
    public async Task<CreateCartResult> Handle(CreateCartCommand request, CancellationToken cancellationToken)
    {
        var cart = _mapper.Map<Cart>(request);
        
        var createdCart = await _cartRepository.CreateCartAsync(cart, cancellationToken);
        
        return _mapper.Map<CreateCartResult>(createdCart);
    }
}
