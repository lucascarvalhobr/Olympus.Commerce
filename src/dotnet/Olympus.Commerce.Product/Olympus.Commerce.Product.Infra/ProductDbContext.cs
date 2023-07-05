using Microsoft.EntityFrameworkCore;
using Olympus.Commerce.Product.Models;

namespace Olympus.Commerce.Product.Infra;

public sealed class ProductDbContext : DbContext
{
    public DbSet<Item> Products { get; set; }

    public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
    {
            
    }
}
