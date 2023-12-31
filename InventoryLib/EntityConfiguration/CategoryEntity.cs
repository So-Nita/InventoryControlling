using InventoryLib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryLib.EntityConfiguration;

public class CategoryEntity : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(e => e.Id);
        builder.HasIndex(e => e.Name).IsUnique();
        
        builder.Property(e => e.Id).IsRequired()
                                   .HasColumnType("varchar")
                                   .HasMaxLength(36);
        builder.Property(e => e.Name).IsRequired()
                                    .HasColumnType("varchar")
                                    .HasMaxLength(50);
        builder.Property(e => e.Description).IsRequired(false)
                                    .HasColumnType("nvarchar")
                                    .HasMaxLength(255).IsUnicode();
        builder.Property(e => e.Image).IsRequired()
                                    .HasColumnType("varchar").HasMaxLength(550);
        builder.Property(e => e.CreatedAt).IsRequired()
                                    .HasColumnType("datetime");
        builder.Property(e => e.IsDeleted).IsRequired(false)
                                    .HasColumnType("bit");

    }
}