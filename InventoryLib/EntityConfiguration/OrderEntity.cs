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
    public class OrderEntity : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).IsRequired().HasColumnType("varchar").HasMaxLength(36);
            builder.Property(e => e.OrderDate).IsRequired().HasColumnType("varchar").HasMaxLength(20);
            builder.Property(e => e.TotalPrice).IsRequired().HasColumnType("decimal(8,2)");

        }
    }
}
