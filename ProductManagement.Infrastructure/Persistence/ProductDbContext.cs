using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProductManagement.Domain.Entities;

namespace ProductManagement.Infrastructure.Persistence;

public class ProductDbContext : DbContext
{
    private readonly string _connectionString = "Server=localhost;database=product;Uid=root;Pwd=root;";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(_connectionString, ServerVersion.AutoDetect(_connectionString));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(x =>
        {
            x.HasKey(p => p.Id);
            x.Ignore(p => p.Notifications);
        });
    }

    public DbSet<Product> Products { get; set; }
}