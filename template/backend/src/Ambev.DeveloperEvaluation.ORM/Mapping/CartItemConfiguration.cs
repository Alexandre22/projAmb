using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ambev.DeveloperEvaluation.ORM.Mapping;

/// <summary>
/// Entity Framework configuration for CartItem entity
/// </summary>
public class CartItemConfiguration : IEntityTypeConfiguration<CartItem>
{
    public void Configure(EntityTypeBuilder<CartItem> builder)
    {
        builder.ToTable("CartItems");

        builder.HasKey(ci => ci.Id);
        builder.Property(ci => ci.Id).ValueGeneratedOnAdd();

        builder.Property(ci => ci.ProductId).IsRequired();
        builder.Property(ci => ci.Quantity).IsRequired();
        builder.Property(ci => ci.CartId).IsRequired();
    }
}
