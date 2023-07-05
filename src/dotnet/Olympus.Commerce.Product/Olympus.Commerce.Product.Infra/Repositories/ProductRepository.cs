using Microsoft.EntityFrameworkCore;
using Olympus.Commerce.Product.Models;
using Olympus.Commerce.Product.Repositories;

namespace Olympus.Commerce.Product.Infra.Repositories;

public sealed class ProductRepository : IProductRepository
{
    private readonly ProductDbContext _context;

    public ProductRepository(ProductDbContext context)
    {
        _context = context;
    }

    public Item GetProductById(Guid id)
    {
        return _context.Products.FirstOrDefault(i => i.Id == id);
    }

    public Task<List<Item>> GetAsync()
    {
        return _context.Products.ToListAsync();
    }

    public async Task InsertAsync(Item item)
    {
        await _context.Products.AddAsync(item);      
    }

    public async Task DeleteAsync(Guid id)
    {
        var item = GetProductById(id);
        _context.Products.Remove(item);
        await SaveAsync();
    }

    public async Task UpdateAsync(Item item)
    {
        _context.Update(item);
        await SaveAsync();
    }

    public async Task SaveAsync()
    {
        await _context.SaveChangesAsync();
    }        
}
