﻿using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Data;
    public class ContosoPizzaContext : DbContext
    {
    public DbSet<Order> Orders { get; set; } = null!;
    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<Customer> Customers { get; set; } = null!;
    public DbSet<OrderDetail> OrderDetails { get; set; } = null!;
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=LAPTOP-D4RM55J7\\SQLEXPRESS;Database=EFCore;Persist Security Info=True;Trusted_Connection=True;TrustServerCertificate=True");
    }
    }
