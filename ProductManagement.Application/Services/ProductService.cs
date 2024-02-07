using ProductManagement.Application.Services.Interfaces;
using ProductManagement.Domain.Entities;
using ProductManagement.Domain.Repositories;

namespace ProductManagement.Application.Services;

public class ProductService : IProductService
{
    private readonly IProductServiceRepository _repository;

    public ProductService(IProductServiceRepository repository)
    {
        _repository = repository;
    }

    public async Task Create(Product product)
    {
        await _repository.Create(product);

        Task.CompletedTask.Wait();
    }

    public async Task Delete(Guid id)
    {
        await _repository.Delete(id);

        Task.CompletedTask.Wait();
    }

    public Task<List<Product>> GetAll()
    {
        return _repository.GetAll();
    }

    public Task<Product> GetById(Guid id)
    {
        return _repository.GetById(id);
    }

    public async Task Update(Guid id, Product product)
    {
        await _repository.Update(id, product);

        Task.CompletedTask.Wait();
    }
}