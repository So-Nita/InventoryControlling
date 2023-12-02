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

    public class StockingEntity : IEntityTypeConfiguration<Stocking>
    {
        public void Configure(EntityTypeBuilder<Stocking> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(36);
            builder.Property(e => e.ProductId).IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(36);
            builder.Property(e => e.Qty).IsRequired().HasColumnType("int");

            builder.Property(e => e.Status)
                .IsRequired()
                .HasColumnType("int")
                .HasConversion<int>();

            builder.Property(e => e.TransactionDate).IsRequired()
                .HasColumnType("datetime");

            builder.HasOne(x => x.Product)
                 .WithMany(p => p.Stockings)
                 .HasForeignKey(x => x.ProductId)
                 .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
