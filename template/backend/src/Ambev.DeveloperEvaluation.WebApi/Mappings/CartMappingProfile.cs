using Ambev.DeveloperEvaluation.Application.Carts.CreateCart;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.WebApi.Features.Carts.CreateCart;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Mappings;

/// <summary>
/// AutoMapper profile for cart-related mappings
/// </summary>
public class CartMappingProfile : Profile
{
    /// <summary>
    /// Initializes a new instance of CartMappingProfile
    /// </summary>
    public CartMappingProfile()
    {
        // Cart item mappings
        CreateMap<CartItemRequest, CartItemCommand>();
        CreateMap<CartItemCommand, CartItem>();
        CreateMap<CartItem, CartItemResult>();
        CreateMap<CartItemResult, CartItemResponse>();

        // Create cart mappings
        CreateMap<CreateCartRequest, CreateCartCommand>();
        
        // Map from command to domain entity
        CreateMap<CreateCartCommand, Cart>()
            .ForMember(dest => dest.CartItems, opt => opt.MapFrom(src => src.Products));
        
        // Map from domain entity to result
        CreateMap<Cart, CreateCartResult>()
            .ForMember(dest => dest.Products, opt => opt.MapFrom(src => src.CartItems));
            
        CreateMap<CreateCartResult, CreateCartResponse>();
    }
}
