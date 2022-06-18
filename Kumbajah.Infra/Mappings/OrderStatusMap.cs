using Kumbajah.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kumbajah.Infra.Mappings
{
    public class OrderStatusMap : IEntityTypeConfiguration<OrderStatus>
    {
        public void Configure(EntityTypeBuilder<OrderStatus> builder)
        {
            builder.ToTable("TB_ORDER_STATUS");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn()
                .HasColumnName("ID")
                .HasColumnType("INT");

            builder.Property(x => x.Status)
                .IsRequired()
                .HasColumnName("STATUS")
                .HasColumnType("VARCHAR(80)");
        }
    }
}
