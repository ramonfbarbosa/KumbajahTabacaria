using Kumbajah.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kumbajah.Infra.Mappings
{
    public class ColorMap : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.ToTable("TB_ORDER_STATUS");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .UseIdentityColumn()
                .HasColumnName("ID")
                .HasColumnType("BIGINT");

            builder.Property(x => x.ColorName)
                .IsRequired()
                .HasColumnName("COLOR_NAME")
                .HasColumnType("VARCHAR(15)");
        }
    }
}
