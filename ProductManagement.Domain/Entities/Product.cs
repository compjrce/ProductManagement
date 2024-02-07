using ProductManagement.Domain.Enum;

namespace ProductManagement.Domain.Entities;

public class Product
{
    public Product(string description, EProductStatus status, DateTime manufacturingDate, DateTime expiryDate, Guid supplierId, string supplierDescription, string supplierCnpj)
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
}