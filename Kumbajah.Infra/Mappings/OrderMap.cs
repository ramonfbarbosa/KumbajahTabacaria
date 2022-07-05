using Kumbajah.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kumbajah.Infra.Mappings
{
    public class OrderMap : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("TAB_PEDIDOS");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .IsRequired()
                .UseIdentityColumn(1, 1)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID")
                .HasColumnType("INT");
            builder.Property(x => x.BuyMoment)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnName("HR_COMPRA")
                .HasColumnType("DATE");
            builder.Property(x => x.PhoneNumber)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnName("CELULAR")
                .HasColumnType("VARCHAR(80)");
            builder.Property(x => x.CPF)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("CPF")
                .HasColumnType("VARCHAR(80)");
            builder.Property(x => x.TotalPrice)
                .IsRequired()
                .HasColumnName("PRECO_TOTAL")
                .HasColumnType("DECIMAL(10,10)");
            builder.Property(x => x.OrderStatusId)
                .IsRequired()
                .HasColumnName("ORDER_STATUS_ID")
                .HasColumnType("INT");
            builder.Property(x => x.UserId)
                .IsRequired()
                .HasColumnName("USER_ID")
                .HasColumnType("INT");
            builder.Property(x => x.AddressId)
               .IsRequired()
               .HasColumnName("ADDRESS_ID")
               .HasColumnType("INT");
        }
    }
}
