﻿using Kumbajah.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kumbajah.Infra.Mappings
{
    public class OrderItemMap : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.ToTable("TB_ORDER_ITEMS");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .UseIdentityColumn()
                .HasColumnName("ID")
                .HasColumnType("BIGINT");

            builder.Property(x => x.Quantity)
                .IsRequired()
                .HasColumnName("QUANTITY")
                .HasColumnType("INT");

            builder.Property(x => x.Price)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("PRICE")
                .HasColumnType("DECIMAL(10,10)");

            builder.Property(x => x.OrderId)
                .IsRequired();
            builder.Property(x => x.ProductId)
                .IsRequired();
        }
    }
}