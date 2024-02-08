using AutoMapper;
using ProductManagement.Application.InputModels;
using ProductManagement.Application.ResponseModels;
using ProductManagement.Application.Services.Interfaces;
using ProductManagement.Application.ViewModels;
using ProductManagement.Domain.Entities;
using ProductManagement.Domain.Notifications;
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

    public async Task<ProductViewModel> GetById(Guid id)
    {
        return _mapper.Map<ProductViewModel>(await _repository.GetById(id));
    }

    public async Task<List<ProductViewModel>> GetAll(ProductsParametersInputModel productsParameters)
    {
        var list = await _repository.GetAll(_mapper.Map<ProductsParameters>(productsParameters));

        return _mapper.Map<List<ProductViewModel>>(list);
    }

    public async Task<ProductResponse> Create(ProductInputModel productInputModel)
    {
        var product = _mapper.Map<Product>(productInputModel);

        if (!product.IsValid())
            return new ProductResponse(_mapper.Map<ProductViewModel>(product), product.Notifications.ToList());

        await _repository.Create(product);

        return new ProductResponse(_mapper.Map<ProductViewModel>(product), product.Notifications.ToList());
    }

    public async Task<ProductResponse> Update(Guid id, ProductInputModel productInputModel)
    {
        var product = await _repository.GetById(id);

        if (product == null)
            return new ProductResponse(null, new List<Notification> { new("Product", $"Id: {id} - not found.") });

        product.UpdateProduct(productInputModel.Description,
                              productInputModel.Status,
                              productInputModel.ManufacturingDate,
                              productInputModel.ExpiryDate,
                              productInputModel.SupplierId,
                              productInputModel.SupplierDescription,
                              productInputModel.SupplierCnpj);

        if (!product.IsValid())
            return new ProductResponse(_mapper.Map<ProductViewModel>(product), product.Notifications.ToList());

        await _repository.Update(id, product);

        return new ProductResponse(null, product.Notifications.ToList());
    }

    public async Task Delete(Guid id)
    {
        await _repository.Delete(id);

        Task.CompletedTask.Wait();
    }
}