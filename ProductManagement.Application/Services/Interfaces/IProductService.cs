using ProductManagement.Application.InputModels;
using ProductManagement.Application.ResponseModels;
using ProductManagement.Application.ViewModels;

namespace ProductManagement.Application.Services.Interfaces;

public interface IProductService
{
    Task<ProductViewModel> GetById(Guid id);

    Task<List<ProductViewModel>> GetAll(ProductsParametersInputModel productsParameters);

    Task<ProductResponse> Create(ProductInputModel productInputModel);

    Task<ProductResponse> Update(Guid id, ProductInputModel productInputModel);

    Task Delete(Guid id);
}