﻿using Kumbajah.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kumbajah.Infra.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("TB_USERS");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .UseIdentityColumn()
                .HasColumnName("ID")
                .HasColumnType("BIGINT");

            builder.Property(x => x.Name + x.LastName)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("NAME")
                .HasColumnType("VARCHAR(180)"); //testar

            builder.Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnName("EMAIL")
                .HasColumnType("VARCHAR(30)");

            builder.Property(x => x.Birthdate)
                .IsRequired()
                .HasColumnName("BIRTHDATE")
                .HasColumnType("DATE");

            builder.Property(x => x.Password)
                .IsRequired()
                .HasMaxLength(180)
                .HasColumnName("PASSWORD")
                .HasColumnType("VARCHAR(50)");

            builder.Property(x => x.CPF)
                .HasMaxLength(11)
                .HasColumnName("CPF")
                .HasColumnType("VARCHAR(15)");

            builder.Property(x => x.PhoneNumber)
                .HasColumnName("PHONE_NUMBER")
                .HasColumnType("VARCHAR(15)");

        }
    }
}
