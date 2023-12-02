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
        builder.Property(e => e.Cost).IsRequired().HasColumnType("decimal(8,2)");
        builder.Property(e => e.Qty).IsRequired(false).HasColumnType("int");
        builder.Property(e => e.CategoryId).IsRequired().HasColumnType("varchar").HasMaxLength(36);
        builder.Property(e => e.Image).IsRequired().HasColumnType("nvarchar").HasMaxLength(550);
        builder.Property(e => e.CreatedAt).IsRequired().HasColumnType("datetime");
        builder.Property(e => e.IsDeleted).IsRequired(false).HasColumnType("bit");

        builder.HasOne(x => x.Category)
            .WithMany(p => p.Products)
            .HasForeignKey(x => x.CategoryId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}