using ProductManagement.Domain.Entities;
using ProductManagement.Domain.Enum;

namespace ProductManagement.Application.ViewModels;

public class ProductViewModel
{
    // public ProductViewModel(Guid id, DateTime createdAt, string description, EProductStatus status, DateTime manufacturingDate, DateTime expiryDate, Guid supplierId, string supplierDescription, string supplierCnpj)
    // {
    //     Id = id;
    //     CreatedAt = createdAt;
    //     Description = description;
    //     Status = status;
    //     ManufacturingDate = manufacturingDate;
    //     ExpiryDate = expiryDate;
    //     SupplierId = supplierId;
    //     SupplierDescription = supplierDescription;
    //     SupplierCnpj = supplierCnpj;
    // }

    public Guid Id { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public string Description { get; private set; }
    public EProductStatus Status { get; private set; }
    public DateTime ManufacturingDate { get; private set; }
    public DateTime ExpiryDate { get; private set; }
    public Guid SupplierId { get; private set; }
    public string SupplierDescription { get; private set; }
    public string SupplierCnpj { get; private set; }

    // public static ProductViewModel FromEntity(Product product) =>
    //     new(product.Id,
    //         product.CreatedAt,
    //         product.Description,
    //         product.Status,
    //         product.ManufacturingDate,
    //         product.ExpiryDate,
    //         product.SupplierId,
    //         product.SupplierDescription,
    //         product.SupplierCnpj);

}