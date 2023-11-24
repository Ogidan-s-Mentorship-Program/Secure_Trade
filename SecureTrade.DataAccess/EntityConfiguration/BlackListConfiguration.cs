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
    public class BlackListConfiguration : IEntityTypeConfiguration<BlackList>
    {
        public void Configure(EntityTypeBuilder<BlackList> builder)
        {
            builder.HasKey(bl => bl.Id);

            builder.Property(bl => bl.IsTemporary)
                .IsRequired();

            builder.Property(bl => bl.Reason)
                .HasMaxLength(500);

            builder.Property(bl => bl.BlackListAt)
                .IsRequired();

            builder.Property(bl => bl.BlackListBy)
                .IsRequired();

            builder.Property(bl => bl.UserId)
                .IsRequired();

            builder.HasOne(bl => bl.User)
                .WithMany()
                .HasForeignKey(bl => bl.UserId)
                                .OnDelete(DeleteBehavior.NoAction);

        }
    }

}
