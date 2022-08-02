using System;
using Microsoft.EntityFrameworkCore;
using EcommerceProject.Entities;
namespace EcommerceProject
{
    public class EcommereContext : DbContext
    {
         protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseMySQL("server=localhost;user=root;database=Ecommerce;port=3306;password=ajibikeabdulqayyumambaaq");
        }
        public DbSet<Category> Categories{get; set;}
        public DbSet<Customer> Customers{get; set;}
        public DbSet<Order> Orders{get; set;}
        public DbSet<Product> Products{get; set;}
        public DbSet<User> Users{get; set;}
        public DbSet<Vendor> Vendors{get; set;}
        public DbSet<Wallet> Wallets{get; set;}
    }
}