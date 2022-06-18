using Kumbajah.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kumbajah.Infra.Mappings
{
    public class OrderMap : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("TB_ORDERS");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID")
                .HasColumnType("INT");

            builder.Property(x => x.BuyMoment)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("BUY_MOMENT")
                .HasColumnType("DATE");

            builder.Property(x => x.PhoneNumber)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("PHONE_NUMBER")
                .HasColumnType("VARCHAR(80)");

            builder.Property(x => x.CPF)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("CPF")
                .HasColumnType("VARCHAR(80)");
        }
    }
}
