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
    public class CustomerSupportConfiguration : IEntityTypeConfiguration<CustomerSupport>
    {
        public void Configure(EntityTypeBuilder<CustomerSupport> builder)
        {
            builder.HasKey(cs => cs.Id);

            builder.Property(cs => cs.Message)
                .IsRequired()
                .HasMaxLength(500); 

            builder.Property(cs => cs.UserId)
                .IsRequired();

            builder.HasOne(cs => cs.User)
                .WithMany()
                .HasForeignKey(cs => cs.UserId)
                                .OnDelete(DeleteBehavior.NoAction);

        }
    }

}
