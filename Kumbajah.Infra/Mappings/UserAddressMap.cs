using Kumbajah.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kumbajah.Infra.Mappings
{
    public class UserAddressMap : IEntityTypeConfiguration<AddressUser>
    {
        public void Configure(EntityTypeBuilder<AddressUser> builder)
        {
            builder.ToTable("TAB_USER_ADDRESS");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .UseIdentityColumn(1, 1)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID")
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
