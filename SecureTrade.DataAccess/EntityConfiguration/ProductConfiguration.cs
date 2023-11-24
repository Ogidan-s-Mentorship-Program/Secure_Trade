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
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Title)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(p => p.Description)
                .HasMaxLength(1000);

            builder.Property(p => p.Price)
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(p => p.StockQuantity)
                .HasMaxLength(10);

            builder.Property(p => p.City)
                .HasMaxLength(50);

            builder.Property(p => p.State)
                .HasMaxLength(50);

            builder.Property(p => p.Country)
                .HasMaxLength(50);

            builder.Property(p => p.UploadedAt)
                .IsRequired();

            builder.Property(p => p.EditedAt)
                .IsRequired();

            builder.Property(p => p.UpdatedBy)
                .IsRequired();

            builder.Property(p => p.IsSold)
                .IsRequired();

            builder.Property(p => p.Views)
                .IsRequired();

            builder.Property(p => p.VendorId)
                .IsRequired();

            builder.HasOne(p => p.Vendor)
                .WithMany()
                .HasForeignKey(p => p.VendorId)
                                .OnDelete(DeleteBehavior.NoAction);

        }
    }

}
