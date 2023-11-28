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
    public class OrderDetailEntity : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).IsRequired().HasColumnType("varchar").HasMaxLength(36);
            builder.Property(e => e.ProductId).IsRequired().HasColumnType("varchar").HasMaxLength(36);
            builder.Property(e => e.OrderId).IsRequired().HasColumnType("varchar").HasMaxLength(36);
            builder.Property(e => e.Qty).IsRequired().HasColumnType("int");
            builder.Property(e => e.Price).IsRequired().HasColumnType("decimal(8,2)");

            builder.HasOne(x => x.Product)
                .WithMany(p => p.OrderDetails)
                .HasForeignKey(x => x.ProductId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.Order)
                .WithMany(p => p.OrderDetails)
                .HasForeignKey(x => x.OrderId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
