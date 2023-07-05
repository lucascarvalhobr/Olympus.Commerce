using Olympus.Commerce.Product.Models.Request;
using Olympus.Commerce.Product.Models.Response;
using Olympus.Commerce.Product.Repositories;
using Olympus.Commerce.Product.Services;

namespace Olympus.Commerce.Product.Infra.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;            
    }

    public Task DeleteAsync(Guid id)
    {
        return _productRepository.DeleteAsync(id);
    }

    public ItemResponse GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<ItemResponse>> GetAsync()
    {
        throw new NotImplementedException();
    }

    public Task InsertAsync(ItemRequest item)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(ItemRequest item)
    {
        throw new NotImplementedException();
    }

    public Task SaveAsync()
    {
        throw new NotImplementedException();
    }
}
