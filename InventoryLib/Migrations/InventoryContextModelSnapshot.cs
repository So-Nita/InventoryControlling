﻿// <auto-generated />
using System;
using InventoryLib.DataConfiguration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InventoryLib.Migrations
{
    [DbContext(typeof(InventoryContext))]
    partial class InventoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("InventoryLib.Models.Category", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<DateTime?>("CreatedAt")
                        .IsRequired()
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(550)
                        .HasColumnType("varchar");

                    b.Property<ulong?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("InventoryLib.Models.Order", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<string>("OrderDate")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("InventoryLib.Models.OrderDetail", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<string>("OrderId")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(8,2)");

                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("InventoryLib.Models.PriceHistory", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<decimal>("CurrentPrice")
                        .HasColumnType("decimal(8,2)");

                    b.Property<decimal>("OldPrice")
                        .HasColumnType("decimal(8,2)");

                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("PriceHistories");
                });

            modelBuilder.Entity("InventoryLib.Models.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<string>("CategoryId")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar");

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(8,2)");

                    b.Property<DateTime?>("CreatedAt")
                        .IsRequired()
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .IsUnicode(true)
                        .HasColumnType("varchar");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(550)
                        .HasColumnType("nvarchar");

                    b.Property<ulong?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("Products");
                });

            modelBuilder.Entity("InventoryLib.Models.Stocking", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Stockings");
                });

            modelBuilder.Entity("InventoryLib.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar");

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(550)
                        .HasColumnType("nvarchar");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<int>("Role")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("InventoryLib.Models.OrderDetail", b =>
                {
                    b.HasOne("InventoryLib.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("InventoryLib.Models.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("InventoryLib.Models.PriceHistory", b =>
                {
                    b.HasOne("InventoryLib.Models.Product", "Product")
                        .WithMany("PriceHistories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("InventoryLib.Models.Product", b =>
                {
                    b.HasOne("InventoryLib.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("InventoryLib.Models.Stocking", b =>
                {
                    b.HasOne("InventoryLib.Models.Product", "Product")
                        .WithMany("Stockings")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("InventoryLib.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("InventoryLib.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("InventoryLib.Models.Product", b =>
                {
                    b.Navigation("OrderDetails");

                    b.Navigation("PriceHistories");

                    b.Navigation("Stockings");
                });
#pragma warning restore 612, 618
        }
    }
}
