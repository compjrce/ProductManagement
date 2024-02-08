using AutoMapper;
using ProductManagement.Application.InputModels;
using ProductManagement.Application.ViewModels;
using ProductManagement.Domain.Entities;

namespace ProductManagement.Application.AutoMapper;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<ProductInputModel, Product>();
        CreateMap<Product, ProductViewModel>();
        CreateMap<ProductsParametersInputModel, ProductsParameters>();
    }
}