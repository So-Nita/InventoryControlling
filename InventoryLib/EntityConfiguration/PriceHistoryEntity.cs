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
    public class PriceHistoryEntity : IEntityTypeConfiguration<PriceHistory>
    {
        public void Configure(EntityTypeBuilder<PriceHistory> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).IsRequired().HasColumnType("varchar").HasMaxLength(36);
            builder.Property(e => e.ProductId).IsRequired().HasColumnType("varchar").HasMaxLength(36);
            builder.Property(e => e.OldPrice).IsRequired().HasColumnType("decimal(8,2)");
            builder.Property(e => e.CurrentPrice).IsRequired().HasColumnType("decimal(8,2)");
            builder.Property(e => e.UpdateDate).IsRequired().HasColumnType("datetime");

            builder.HasOne(x => x.Product)
               .WithMany(p => p.PriceHistories)
               .HasForeignKey(x => x.ProductId)
               .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
