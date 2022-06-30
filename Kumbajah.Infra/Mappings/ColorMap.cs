using Kumbajah.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kumbajah.Infra.Mappings
{
    public class ColorMap : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.ToTable("TAB_CORES");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn(1, 1)
                .HasColumnName("ID")
                .HasColumnType("INT");

            builder.Property(x => x.ColorName)
                .IsRequired()
                .HasColumnName("NM_COR")
                .HasColumnType("VARCHAR(80)");
        }
    }
}
