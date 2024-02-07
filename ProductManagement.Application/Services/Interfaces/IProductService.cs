using ProductManagement.Domain.Entities;

namespace ProductManagement.Application.Services.Interfaces;

public interface IProductService
{
    Task<Product> GetById();

    Task<List<Product>> GetAll();

    Task Create(Product product);

    Task Update(Guid id, Product product);

    Task Delete(Guid id);
}