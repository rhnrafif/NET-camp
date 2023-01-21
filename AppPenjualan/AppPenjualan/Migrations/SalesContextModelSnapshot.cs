﻿// <auto-generated />
using System;
using AppPenjualan.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppPenjualan.Migrations
{
    [DbContext(typeof(SalesContext))]
    partial class SalesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AppPenjualan.Database.Products", b =>
                {
                    b.Property<int>("ProductsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductsId"));

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .HasColumnType("NVarchar(10)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("NVarchar(100)");

                    b.Property<int?>("ProductPrice")
                        .HasColumnType("int");

                    b.Property<int?>("ProductQty")
                        .HasColumnType("int");

                    b.Property<int>("SuppliersId")
                        .HasColumnType("int");

                    b.HasKey("ProductsId");

                    b.HasIndex("SuppliersId");

                    b.ToTable("Products", "dbo");
                });

            modelBuilder.Entity("AppPenjualan.Database.Suppliers", b =>
                {
                    b.Property<int>("SuppliersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SuppliersId"));

                    b.Property<string>("SupplierAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierName")
                        .IsRequired()
                        .HasColumnType("NVarchar(100)");

                    b.HasKey("SuppliersId");

                    b.ToTable("Suppliers", "dbo");
                });

            modelBuilder.Entity("AppPenjualan.Database.TransactionDetails", b =>
                {
                    b.Property<int>("TransactionDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransactionDetailId"));

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<int>("SubTotal")
                        .HasColumnType("int");

                    b.Property<int>("TransactionsId")
                        .HasColumnType("int");

                    b.HasKey("TransactionDetailId");

                    b.HasIndex("ProductsId");

                    b.HasIndex("TransactionsId");

                    b.ToTable("TransactionDetails", "dbo");
                });

            modelBuilder.Entity("AppPenjualan.Database.Transactionns", b =>
                {
                    b.Property<int>("TransactionsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransactionsId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.Property<string>("TransactionCode")
                        .IsRequired()
                        .HasColumnType("Nvarchar(10)");

                    b.Property<DateTime?>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.HasKey("TransactionsId");

                    b.ToTable("Transactionns", "dbo");
                });

            modelBuilder.Entity("AppPenjualan.Database.Products", b =>
                {
                    b.HasOne("AppPenjualan.Database.Suppliers", null)
                        .WithMany("Products")
                        .HasForeignKey("SuppliersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppPenjualan.Database.TransactionDetails", b =>
                {
                    b.HasOne("AppPenjualan.Database.Products", "Products")
                        .WithMany("TransactionDetails")
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppPenjualan.Database.Transactionns", "Transactions")
                        .WithMany("TransactionDetails")
                        .HasForeignKey("TransactionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Products");

                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("AppPenjualan.Database.Products", b =>
                {
                    b.Navigation("TransactionDetails");
                });

            modelBuilder.Entity("AppPenjualan.Database.Suppliers", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("AppPenjualan.Database.Transactionns", b =>
                {
                    b.Navigation("TransactionDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
