using ProductManagement.Domain.Enum;

namespace ProductManagement.Application.InputModels;

public class ProductInputModel
{
    public string Description { get; private set; }
    public EProductStatus Status { get; private set; }
    public DateTime ManufacturingDate { get; private set; }
    public DateTime ExpiryDate { get; private set; }
    public Guid SupplierId { get; private set; }
    public string SupplierDescription { get; private set; }
    public string SupplierCnpj { get; private set; }
}

public class ProductsParametersInputModel
{
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
}