using ProductManagement.Application.Services.Interfaces;
using ProductManagement.Domain.Entities;

namespace ProductManagement.Application.Services;

public class ProductService : IProductService
{
    public Task Create(Product product)
    {
        throw new NotImplementedException();
    }

    public Task Delete(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Product>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<Product> GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task Update(Guid id, Product product)
    {
        throw new NotImplementedException();
    }
}