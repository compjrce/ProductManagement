using ProductManagement.Domain.Entities;

namespace ProductManagement.Application.Services.Interfaces;

public interface IProductService
{
    Task<Product> GetById(Guid id);

    Task<List<Product>> GetAll(ProductsParameters productsParameters);

    Task Create(Product product);

    Task Update(Guid id, Product product);

    Task Delete(Guid id);
}