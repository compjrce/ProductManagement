using ProductManagement.Domain.Enum;

namespace ProductManagement.Application.InputModels;

public class ProductInputModel
{
    public ProductInputModel(string description, EProductStatus status, DateTime manufacturingDate, DateTime expiryDate, Guid supplierId, string supplierDescription, string supplierCnpj)
    {
        Description = description;
        Status = status;
        ManufacturingDate = manufacturingDate;
        ExpiryDate = expiryDate;
        SupplierId = supplierId;
        SupplierDescription = supplierDescription;
        SupplierCnpj = supplierCnpj;
    }

    public string Description { get; set; }
    public EProductStatus Status { get; set; }
    public DateTime ManufacturingDate { get; set; }
    public DateTime ExpiryDate { get; set; }
    public Guid SupplierId { get; set; }
    public string SupplierDescription { get; set; }
    public string SupplierCnpj { get; set; }
}

public class ProductsParametersInputModel
{
    const int maxPageSize = 50;

    public int PageNumber { get; set; } = 1;

    private int _pageSize = 10;

    public int PageSize
    {
        get
        {
            return _pageSize;
        }
        set
        {
            _pageSize = (value > maxPageSize) ? maxPageSize : value;
        }
    }
}