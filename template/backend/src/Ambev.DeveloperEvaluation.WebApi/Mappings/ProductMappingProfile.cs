using Ambev.DeveloperEvaluation.Application.Products.CreateProduct;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProduct;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Mappings;

/// <summary>
/// AutoMapper profile for product-related mappings
/// </summary>
public class ProductMappingProfile : Profile
{
    /// <summary>
    /// Initializes a new instance of ProductMappingProfile
    /// </summary>
    public ProductMappingProfile()
    {
        // Product rating mappings
        CreateMap<ProductRatingRequest, ProductRating>();
        CreateMap<ProductRating, ProductRatingResponse>();

        // Create product mappings
        CreateMap<CreateProductRequest, CreateProductCommand>();
        CreateMap<CreateProductResult, CreateProductResponse>();
        CreateMap<CreateProductCommand, Product>();
        CreateMap<Product, CreateProductResult>();
    }
}
