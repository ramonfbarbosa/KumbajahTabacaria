using Kumbajah.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kumbajah.Infra.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("USER");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .UseIdentityColumn()
                .HasColumnType("BIGINT");

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("NAME")
                .HasColumnType("VARCHAR(80)");

            builder.Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(80)
                .HasColumnName("LAST_NAME")
                .HasColumnType("VARCHAR(80)");

            builder.Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnName("EMAIL")
                .HasColumnType("VARCHAR(30)");

            builder.Property(x => x.CPF)
                .IsRequired()
                .HasMaxLength(11)
                .HasColumnName("CPF")
                .HasColumnType("BIGINT");

            builder.Property(x => x.PhoneNumber)
                .IsRequired()
                .HasColumnName("PHONE_NUMBER")
                .HasColumnType("BIGINT");

            builder.Property(x => x.Password)
                .IsRequired()
                .HasMaxLength(180)
                .HasColumnName("PASSWORD")
                .HasColumnType("VARCHAR(180)");

            builder.Property(x => x.Birthday)
                .IsRequired()
                .HasColumnName("BIRTHDAY")
                .HasColumnType("date");
        }
    }
}
