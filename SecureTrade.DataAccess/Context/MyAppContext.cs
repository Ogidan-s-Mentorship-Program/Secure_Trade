using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SecureTrade.DataAccess.Entities;

namespace SecureTrade.DataAccess.Context
{
    public class MyAppContext: DbContext
    {
        public MyAppContext(DbContextOptions<MyAppContext> options): base(options)
    {
        
    }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<CustomerSupport> CustomerSupports { get; set; }
        public DbSet<BlackList> BlackLists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure the one-to-one relationship between CustomerSupport and Vendor
            modelBuilder.Entity<CustomerSupport>()
                .HasKey(cs => cs.Id); // Set the primary key for CustomerSupport

            //modelBuilder.Entity<CustomerSupport>()
            //    .HasOne<Vendor>(cs => cs.Vendor) // CustomerSupport has one Vendor
            //    .WithOne(v => v.CustomerSupport) // Vendor has one CustomerSupport
            //    .HasForeignKey<Vendor>(v => v.CustomerSupportId) // Foreign key on Vendor entity
            //    .OnDelete(DeleteBehavior.Restrict); // Set the delete behavior
        }

    }
}