using Kumbajah.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kumbajah.Infra.Mappings
{
    public class OrderStatusMap : IEntityTypeConfiguration<OrderStatus>
    {
        public void Configure(EntityTypeBuilder<OrderStatus> builder)
        {
            builder.ToTable("TAB_STATUS_DO_PEDIDO");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .UseIdentityColumn(1, 1)
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
