using InventoryLib.Constant;
using InventoryLib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            builder.Property(e => e.Role).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            builder.Property(e => e.Contact).IsRequired().HasColumnType("long");
            builder.Property(e => e.Password).IsRequired().HasColumnType("varchar").HasMaxLength(50);
        }
    }
}
