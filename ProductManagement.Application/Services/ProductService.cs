using AutoMapper;
using ProductManagement.Application.InputModels;
using ProductManagement.Application.ResponseModels;
using ProductManagement.Application.Services.Interfaces;
using ProductManagement.Application.ViewModels;
using ProductManagement.Domain.Entities;
using ProductManagement.Domain.Repositories;

namespace ProductManagement.Application.Services;

public class ProductService : IProductService
{
    private readonly IProductServiceRepository _repository;
    private readonly IMapper _mapper;

    public ProductService(IProductServiceRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<ProductResponse> Create(ProductInputModel productInputModel)
    {
        var product = productInputModel.FromEntity();

        if (!product.IsValid())
            return new ProductResponse(product, product.Notifications.ToList());

        await _repository.Create(product);

        return new ProductResponse(product, product.Notifications.ToList());
    }

    public async Task Delete(Guid id)
    {
        await _repository.Delete(id);

        Task.CompletedTask.Wait();
    }

    public Task<List<Product>> GetAll(ProductsParameters productsParameters)
    {
        return _repository.GetAll(productsParameters);
    }

    public async Task<ProductViewModel> GetById(Guid id)
    {
        return _mapper.Map<ProductViewModel>(await _repository.GetById(id));
    }

    public async Task Update(Guid id, Product product)
    {
        await _repository.Update(id, product);

        Task.CompletedTask.Wait();
    }
}