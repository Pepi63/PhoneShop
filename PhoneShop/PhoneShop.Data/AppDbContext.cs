using Microsoft.EntityFrameworkCore;
using PhoneShop.Models;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace PhoneShop.Data
{
    public class AppDbContext : DbContext
    {
        private const string connectionString = @"Server=DESKTOP-SMRRC3M; Initial Catalog=PhoneShopEf; Integrated Security=true; Trusted_Connection=true";
        public virtual DbSet<Phone> Phones { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);

            }
            optionsBuilder.UseLazyLoadingProxies();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Order>()
        .HasMany(o => o.OrderDetails)
        .WithOne()
        .HasForeignKey(od => od.OrderID);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Phone)
                .WithOne()
                .HasForeignKey<OrderDetail>(od => od.PhoneID);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Employee)
                .WithMany(e => e.Orders)
                .HasForeignKey(o => o.EmployeeID);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CustomerID);
        }


    }
}
