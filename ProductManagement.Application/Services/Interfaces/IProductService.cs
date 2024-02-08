using ProductManagement.Application.InputModels;
using ProductManagement.Application.ResponseModels;
using ProductManagement.Application.ViewModels;
using ProductManagement.Domain.Entities;

namespace ProductManagement.Application.Services.Interfaces;

public interface IProductService
{
    Task<ProductViewModel> GetById(Guid id);

    Task<List<Product>> GetAll(ProductsParameters productsParameters);

    Task<ProductResponse> Create(ProductInputModel productInputModel);

    Task Update(Guid id, Product product);

    Task Delete(Guid id);
}