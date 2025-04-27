using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ambev.DeveloperEvaluation.ORM.Mapping;

/// <summary>
/// Entity Framework configuration for User entity
/// </summary>
public class UserConfiguration : IEntityTypeConfiguration<User>
{
    /// <summary>
    /// Configures the User entity mapping
    /// </summary>
    /// <param name="builder">The entity type builder</param>
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");
        
        builder.HasKey(u => u.Id);
        
        builder.Property(u => u.Username)
            .IsRequired()
            .HasMaxLength(100);
            
        builder.Property(u => u.Email)
            .IsRequired()
            .HasMaxLength(255);
            
        builder.Property(u => u.Password)
            .IsRequired()
            .HasMaxLength(255);
            
        builder.Property(u => u.Phone)
            .HasMaxLength(20);
            
        builder.Property(u => u.Role)
            .IsRequired();
            
        builder.Property(u => u.Status)
            .IsRequired();
            
        builder.Property(u => u.CreatedAt)
            .IsRequired();
            
        builder.Property(u => u.UpdatedAt);
        
        // Configure complex types
        builder.OwnsOne(u => u.Name, name =>
        {
            name.Property(n => n.Firstname)
                .HasColumnName("FirstName")
                .HasMaxLength(100);
                
            name.Property(n => n.Lastname)
                .HasColumnName("LastName")
                .HasMaxLength(100);
        });
        
        builder.OwnsOne(u => u.Address, address =>
        {
            address.Property(a => a.City)
                .HasColumnName("City")
                .HasMaxLength(100);
                
            address.Property(a => a.Street)
                .HasColumnName("Street")
                .HasMaxLength(200);
                
            address.Property(a => a.Number)
                .HasColumnName("StreetNumber");
                
            address.Property(a => a.Zipcode)
                .HasColumnName("ZipCode")
                .HasMaxLength(20);
                
            address.OwnsOne(a => a.Geolocation, geo =>
            {
                geo.Property(g => g.Lat)
                    .HasColumnName("Latitude")
                    .HasMaxLength(50);
                    
                geo.Property(g => g.Long)
                    .HasColumnName("Longitude")
                    .HasMaxLength(50);
            });
        });
        
        // Create unique index on email
        builder.HasIndex(u => u.Email)
            .IsUnique();
    }
}
