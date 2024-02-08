using ProductManagement.Domain.Enum;

namespace ProductManagement.Application.ViewModels;

public class ProductViewModel
{
    public Guid Id { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public string Description { get; private set; }
    public EProductStatus Status { get; private set; }
    public DateTime ManufacturingDate { get; private set; }
    public DateTime ExpiryDate { get; private set; }
    public Guid SupplierId { get; private set; }
    public string SupplierDescription { get; private set; }
    public string SupplierCnpj { get; private set; }
}