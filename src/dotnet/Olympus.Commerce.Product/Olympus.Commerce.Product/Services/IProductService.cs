using Olympus.Commerce.Product.Models.Request;
using Olympus.Commerce.Product.Models.Response;

namespace Olympus.Commerce.Product.Services;

public interface IProductService
{
    ItemResponse GetById(Guid id);

    Task<List<ItemResponse>> GetAsync();

    Task InsertAsync(ItemRequest item);

    Task DeleteAsync(Guid id);

    Task UpdateAsync(ItemRequest item);

    Task SaveAsync();
}
