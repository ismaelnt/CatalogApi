using CatalogApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CatalogApi.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Category>? Category { get; set; }
    public DbSet<Product>? Products { get; set; }
}
