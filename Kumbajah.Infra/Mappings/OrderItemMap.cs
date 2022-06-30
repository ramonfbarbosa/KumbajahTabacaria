using Kumbajah.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kumbajah.Infra.Mappings
{
    public class OrderItemMap : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.ToTable("TAB_ITENS_DE_PEDIDO");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .UseIdentityColumn(1, 1)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID")
                .HasColumnType("INT");

            builder.Property(x => x.Quantity)
                .IsRequired()
                .HasColumnName("QUANTIDADE")
                .HasColumnType("INT");

            builder.Property(x => x.Price)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("PRECO")
                .HasColumnType("DECIMAL(10,10)");

            builder.Property(x => x.ProductId)
                .IsRequired()
                .HasColumnName("PRODUCT_ID")
                .HasColumnType("INT");

            builder.Property(x => x.OrderId)
                .IsRequired()
                .HasColumnName("ORDER_ID")
                .HasColumnType("INT");
        }
    }
}
