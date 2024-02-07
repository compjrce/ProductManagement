using ProductManagement.Domain.Entities;

namespace ProductManagement.Domain.Repositories;

public interface IProductServiceRepository
{
    Task<Product> GetById(Guid id);

    Task<List<Product>> GetAll(ProductsParameters productsParameters);

    Task Create(Product product);

    Task Update(Guid id, Product product);

    Task Delete(Guid id);
}