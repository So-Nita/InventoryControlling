using InventoryLib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryLib.EntityConfiguration;

public class ProductEntity : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(e => e.Id);
        builder.HasIndex(e => e.Code).IsUnique();
        
        builder.Property(e => e.Id).IsRequired().HasColumnType("varchar").HasMaxLength(36);
        builder.Property(e => e.Code).IsRequired().HasColumnType("varchar").HasMaxLength(20);
        builder.Property(e => e.Name).IsRequired().HasColumnType("varchar").HasMaxLength(50);
        builder.Property(e => e.Description).IsRequired(false).HasColumnType("varchar").HasMaxLength(100).IsUnicode();
        builder.Property(e => e.Price).IsRequired().HasColumnType("decimal(8,2)");
        builder.Property(e => e.SellPrice).IsRequired().HasColumnType("decimal(8,2)");
        builder.Property(e => e.CategoryId).IsRequired().HasColumnType("varchar").HasMaxLength(36);
        builder.Property(e => e.CreatedAt).IsRequired().HasColumnType("datetime");
        builder.Property(e => e.IsDeleted).IsRequired(false).HasColumnType("bit");
        
        builder.HasOne(e => e.Category)
            .WithMany(category => category.Products)
            .HasForeignKey(e => e.CategoryId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}