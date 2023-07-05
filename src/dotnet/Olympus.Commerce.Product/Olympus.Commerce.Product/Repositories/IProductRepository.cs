using Olympus.Commerce.Product.Models;

namespace Olympus.Commerce.Product.Repositories;

public interface IProductRepository
{
    Item GetProductById(Guid id);

    Task<List<Item>> GetAsync();

    Task InsertAsync(Item item);

    Task DeleteAsync(Guid id);

    Task UpdateAsync(Item item);

    Task SaveAsync();
}
