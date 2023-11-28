using InventoryLib.Constant;
using InventoryLib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryLib.EntityConfiguration
{
    public class UserEntity : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasIndex(e => e.UserName).IsUnique();

            builder.Property(e => e.Id).IsRequired().HasColumnType("varchar").HasMaxLength(36);
            builder.Property(e => e.UserName).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            builder.Property(e => e.Role)
                .IsRequired()
                .HasColumnType("int")   
                .HasMaxLength(50)
                .HasConversion<int>();   

            builder.Property(e => e.Image).IsRequired().HasColumnType("nvarchar").HasMaxLength(550);
            builder.Property(e => e.Contact).IsRequired().HasColumnType("varchar").HasMaxLength(15);
            builder.Property(e => e.Password).IsRequired().HasColumnType("varchar").HasMaxLength(50);
        }
    }
}
