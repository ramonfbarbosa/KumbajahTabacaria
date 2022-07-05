﻿// <auto-generated />
using System;
using Kumbajah.Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KumbajahTabacaria.Migrations
{
    [DbContext(typeof(KumbajahContext))]
    [Migration("20220705224654_TestandoUmaCoisa")]
    partial class TestandoUmaCoisa
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

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
                        .HasColumnType("VARCHAR(20)")
                        .HasColumnName("CIDADE");

                    b.Property<string>("Complement")
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR(MAX)")
                        .HasColumnName("COMPLEMENTO");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR(20)")
                        .HasColumnName("BAIRRO");

                    b.Property<int>("Number")
                        .HasColumnType("INT")
                        .HasColumnName("NUMERO");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("Reference")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR(MAX)")
                        .HasColumnName("REFERENCIA");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR(20)")
                        .HasColumnName("ESTADO");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR(MAX)")
                        .HasColumnName("RUA");

                    b.HasKey("Id");

                    b.ToTable("TAB_ENDERECOS");
                });

            modelBuilder.Entity("Kumbajah.Domain.Entities.AddressUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("ID")
                        .UseIdentityColumn();

                    b.Property<int>("AddressId")
                        .HasColumnType("INT")
                        .HasColumnName("ADDRESS_ID");

                    b.Property<int>("UserId")
                        .HasColumnType("INT")
                        .HasColumnName("USER_ID");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("TAB_USER_ADDRESS");
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
                        .HasColumnName("NM_MARCA");

                    b.HasKey("Id");

                    b.ToTable("TAB_MARCAS");
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
                        .HasColumnName("NM_CATEGORIA");

                    b.HasKey("Id");

                    b.ToTable("TAB_CATEGORIAS");
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
                        .HasColumnName("NM_COR");

                    b.HasKey("Id");

                    b.ToTable("TAB_CORES");
                });

            modelBuilder.Entity("Kumbajah.Domain.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("ID")
                        .UseIdentityColumn();

                    b.Property<int>("AddressId")
                        .HasColumnType("INT");

                    b.Property<DateTime>("BuyMoment")
                        .HasMaxLength(30)
                        .HasColumnType("DATE")
                        .HasColumnName("HR_COMPRA");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR(20)")
                        .HasColumnName("CPF");

                    b.Property<int>("OrderStatusId")
                        .HasColumnType("INT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("VARCHAR(30)")
                        .HasColumnName("CELULAR");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("DECIMAL(10,10)")
                        .HasColumnName("PRECO_TOTAL");

                    b.Property<int>("UserId")
                        .HasColumnType("INT");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.HasIndex("OrderStatusId");

                    b.HasIndex("UserId");

                    b.ToTable("TAB_PEDIDOS");
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
                        .HasColumnName("PRECO");

                    b.Property<int>("ProductId")
                        .HasColumnType("INT")
                        .HasColumnName("PRODUCT_ID");

                    b.Property<int>("Quantity")
                        .HasColumnType("INT")
                        .HasColumnName("QUANTIDADE");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("TAB_ITENS_DE_PEDIDO");
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

                    b.ToTable("TAB_STATUS_DO_PEDIDO");
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

                    b.Property<int?>("ColorId")
                        .IsRequired()
                        .HasColumnType("INT")
                        .HasColumnName("COLOR_ID");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(180)
                        .HasColumnType("VARCHAR(180)")
                        .HasColumnName("DESCRICAO");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)")
                        .HasColumnName("IMAGEM");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("VARCHAR(80)")
                        .HasColumnName("NOME");

                    b.Property<decimal>("Price")
                        .HasColumnType("DECIMAL(10,10)")
                        .HasColumnName("PRECO");

                    b.Property<int>("StockId")
                        .HasColumnType("INT")
                        .HasColumnName("STOCK_ID");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ColorId");

                    b.HasIndex("StockId")
                        .IsUnique();

                    b.ToTable("TAB_PRODUTOS");
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
                        .HasColumnName("QUANTIDADE");

                    b.HasKey("Id");

                    b.ToTable("TAB_ESTOQUE");
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
                        .HasColumnName("DT_ANIVERSARIO");

                    b.Property<string>("CPF")
                        .HasMaxLength(11)
                        .HasColumnType("VARCHAR(11)")
                        .HasColumnName("CPF");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("VARCHAR(30)")
                        .HasColumnName("EMAIL");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR(20)")
                        .HasColumnName("SOBRENOME");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR(20)")
                        .HasColumnName("NAME");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(180)
                        .HasColumnType("VARCHAR(180)")
                        .HasColumnName("SENHA");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("VARCHAR(20)")
                        .HasColumnName("CELULAR");

                    b.HasKey("Id");

                    b.ToTable("TAB_CLIENTES");
                });

            modelBuilder.Entity("Kumbajah.Domain.Entities.AddressUser", b =>
                {
                    b.HasOne("Kumbajah.Domain.Entities.Address", "Address")
                        .WithMany("UserAddress")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kumbajah.Domain.Entities.User", "User")
                        .WithMany("UserAddress")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Kumbajah.Domain.Entities.Order", b =>
                {
                    b.HasOne("Kumbajah.Domain.Entities.Address", "Address")
                        .WithOne("Order")
                        .HasForeignKey("Kumbajah.Domain.Entities.Order", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kumbajah.Domain.Entities.OrderStatus", "OrderStatus")
                        .WithMany("Orders")
                        .HasForeignKey("OrderStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kumbajah.Domain.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("OrderStatus");

                    b.Navigation("User");
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
                    b.Navigation("Order");

                    b.Navigation("UserAddress");
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

                    b.Navigation("UserAddress");
                });
#pragma warning restore 612, 618
        }
    }
}
