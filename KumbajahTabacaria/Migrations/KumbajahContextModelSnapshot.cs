﻿// <auto-generated />
using System;
using Kumbajah.Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KumbajahTabacaria.Migrations
{
    [DbContext(typeof(KumbajahContext))]
    partial class KumbajahContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("AddressUser", b =>
                {
                    b.Property<int>("AddressesId")
                        .HasColumnType("INT");

                    b.Property<int>("UsersId")
                        .HasColumnType("INT");

                    b.HasKey("AddressesId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("AddressUser");
                });

            modelBuilder.Entity("Kumbajah.Domain.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("ID")
                        .UseIdentityColumn();

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR(20)")
                        .HasColumnName("CEP");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR(MAX)")
                        .HasColumnName("CITY");

                    b.Property<string>("Complement")
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR(MAX)")
                        .HasColumnName("COMPLEMENT");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR(20)")
                        .HasColumnName("DISTRICT");

                    b.Property<int>("Number")
                        .HasColumnType("INT")
                        .HasColumnName("NUMBER");

                    b.Property<string>("Reference")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR(MAX)")
                        .HasColumnName("REFERENCE");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR(MAX)")
                        .HasColumnName("STATE");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR(MAX)")
                        .HasColumnName("STREET");

                    b.HasKey("Id");

                    b.ToTable("TB_ADDRESSES");
                });

            modelBuilder.Entity("Kumbajah.Domain.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("ID")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR(20)")
                        .HasColumnName("NAME");

                    b.HasKey("Id");

                    b.ToTable("TB_BRANDS");
                });

            modelBuilder.Entity("Kumbajah.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("ID")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("VARCHAR(80)")
                        .HasColumnName("NAME");

                    b.HasKey("Id");

                    b.ToTable("TB_CATEGORIES");
                });

            modelBuilder.Entity("Kumbajah.Domain.Entities.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("ID")
                        .UseIdentityColumn();

                    b.Property<string>("ColorName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(80)")
                        .HasColumnName("COLOR_NAME");

                    b.HasKey("Id");

                    b.ToTable("TB_COLORS");
                });

            modelBuilder.Entity("Kumbajah.Domain.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("ID")
                        .UseIdentityColumn();

                    b.Property<int>("AddressId")
                        .HasColumnType("INT")
                        .HasColumnName("ADDRESS_ID");

                    b.Property<DateTime>("BuyMoment")
                        .HasMaxLength(20)
                        .HasColumnType("DATE")
                        .HasColumnName("BUY_MOMENT");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR(20)")
                        .HasColumnName("CPF");

                    b.Property<int>("OrderStatusId")
                        .HasColumnType("INT")
                        .HasColumnName("ORDER_STATUS_ID");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR(20)")
                        .HasColumnName("PHONE_NUMBER");

                    b.Property<int>("UserId")
                        .HasColumnType("INT")
                        .HasColumnName("USER_ID");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("OrderStatusId");

                    b.HasIndex("UserId");

                    b.ToTable("TB_ORDERS");
                });

            modelBuilder.Entity("Kumbajah.Domain.Entities.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("ID")
                        .UseIdentityColumn();

                    b.Property<int>("OrderId")
                        .HasColumnType("INT")
                        .HasColumnName("ORDER_ID");

                    b.Property<decimal>("Price")
                        .HasMaxLength(20)
                        .HasColumnType("DECIMAL(10,10)")
                        .HasColumnName("PRICE");

                    b.Property<int>("ProductId")
                        .HasColumnType("INT")
                        .HasColumnName("PRODUCT_ID");

                    b.Property<int>("Quantity")
                        .HasColumnType("INT")
                        .HasColumnName("QUANTITY");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("TB_ORDER_ITEMS");
                });

            modelBuilder.Entity("Kumbajah.Domain.Entities.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("ID")
                        .UseIdentityColumn();

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("VARCHAR(80)")
                        .HasColumnName("STATUS");

                    b.HasKey("Id");

                    b.ToTable("TB_ORDER_STATUS");
                });

            modelBuilder.Entity("Kumbajah.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("ID")
                        .UseIdentityColumn();

                    b.Property<int>("BrandId")
                        .HasColumnType("INT")
                        .HasColumnName("BRAND_ID");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INT")
                        .HasColumnName("CATEGORY_ID");

                    b.Property<int>("ColorId")
                        .HasColumnType("INT")
                        .HasColumnName("COLOR_ID");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(180)
                        .HasColumnType("VARCHAR(180)")
                        .HasColumnName("DESCRIPTION");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)")
                        .HasColumnName("IMAGE");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("VARCHAR(80)")
                        .HasColumnName("NAME");

                    b.Property<decimal>("Price")
                        .HasColumnType("DECIMAL(10,10)")
                        .HasColumnName("PRICE");

                    b.Property<int>("StockId")
                        .HasColumnType("INT")
                        .HasColumnName("STOCK_ID");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ColorId");

                    b.HasIndex("StockId")
                        .IsUnique();

                    b.ToTable("TB_PRODUCTS");
                });

            modelBuilder.Entity("Kumbajah.Domain.Entities.Stock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("ID")
                        .UseIdentityColumn();

                    b.Property<int>("Quantity")
                        .HasColumnType("INT")
                        .HasColumnName("QUANTITY");

                    b.HasKey("Id");

                    b.ToTable("TB_STOCKS");
                });

            modelBuilder.Entity("Kumbajah.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("ID")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("DATE")
                        .HasColumnName("BIRTH_DATE");

                    b.Property<string>("CPF")
                        .HasMaxLength(11)
                        .HasColumnType("VARCHAR(11)")
                        .HasColumnName("CPF");

                    b.Property<string>("ConfirmPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("VARCHAR(30)")
                        .HasColumnName("EMAIL");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR(20)")
                        .HasColumnName("LAST_NAME");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR(20)")
                        .HasColumnName("NAME");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(180)
                        .HasColumnType("VARCHAR(180)")
                        .HasColumnName("PASSWORD");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("VARCHAR(80)")
                        .HasColumnName("PHONE_NUMBER");

                    b.HasKey("Id");

                    b.ToTable("TB_USERS");
                });

            modelBuilder.Entity("AddressUser", b =>
                {
                    b.HasOne("Kumbajah.Domain.Entities.Address", null)
                        .WithMany()
                        .HasForeignKey("AddressesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kumbajah.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Kumbajah.Domain.Entities.Order", b =>
                {
                    b.HasOne("Kumbajah.Domain.Entities.Address", "Address")
                        .WithMany("Orders")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kumbajah.Domain.Entities.OrderStatus", "OrderStatus")
                        .WithMany("Orders")
                        .HasForeignKey("OrderStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kumbajah.Domain.Entities.User", "Users")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("OrderStatus");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Kumbajah.Domain.Entities.OrderItem", b =>
                {
                    b.HasOne("Kumbajah.Domain.Entities.Order", "Order")
                        .WithMany("Items")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kumbajah.Domain.Entities.Product", "Product")
                        .WithMany("Items")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Kumbajah.Domain.Entities.Product", b =>
                {
                    b.HasOne("Kumbajah.Domain.Entities.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kumbajah.Domain.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kumbajah.Domain.Entities.Color", "Color")
                        .WithMany("Products")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kumbajah.Domain.Entities.Stock", "Stock")
                        .WithOne("Product")
                        .HasForeignKey("Kumbajah.Domain.Entities.Product", "StockId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Category");

                    b.Navigation("Color");

                    b.Navigation("Stock");
                });

            modelBuilder.Entity("Kumbajah.Domain.Entities.Address", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Kumbajah.Domain.Entities.Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Kumbajah.Domain.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Kumbajah.Domain.Entities.Color", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Kumbajah.Domain.Entities.Order", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("Kumbajah.Domain.Entities.OrderStatus", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Kumbajah.Domain.Entities.Product", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("Kumbajah.Domain.Entities.Stock", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("Kumbajah.Domain.Entities.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
