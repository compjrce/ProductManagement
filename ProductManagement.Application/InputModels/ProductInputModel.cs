using ProductManagement.Domain.Entities;
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

    public string Description { get; private set; }
    public EProductStatus Status { get; private set; }
    public DateTime ManufacturingDate { get; private set; }
    public DateTime ExpiryDate { get; private set; }
    public Guid SupplierId { get; private set; }
    public string SupplierDescription { get; private set; }
    public string SupplierCnpj { get; private set; }

    public Product FromEntity() =>
        new(Description,
            Status,
            ManufacturingDate,
            ExpiryDate,
            SupplierId,
            SupplierDescription,
            SupplierCnpj);
}