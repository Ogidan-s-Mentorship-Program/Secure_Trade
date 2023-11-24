using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SecureTrade.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureTrade.DataAccess.EntityConfiguration
{
    public class VendorConfiguration : IEntityTypeConfiguration<Vendor>
    {
        public void Configure(EntityTypeBuilder<Vendor> builder)
        {
            builder.HasKey(v => v.Id);

            builder.Property(v => v.CompanyName)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(v => v.CompanyAddress)
                .HasMaxLength(500);

            builder.Property(v => v.City)
                .HasMaxLength(50);

            builder.Property(v => v.State)
                .HasMaxLength(50);

            builder.Property(v => v.ZipCode)
                .HasMaxLength(10);

            builder.Property(v => v.UserId)
                .IsRequired();

            builder.HasOne(v => v.User)
                .WithMany()
                .HasForeignKey(v => v.UserId)
                            .OnDelete(DeleteBehavior.NoAction);

        }
    }

}
