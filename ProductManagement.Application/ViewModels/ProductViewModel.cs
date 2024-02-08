using ProductManagement.Domain.Enum;

namespace ProductManagement.Application.ViewModels;

public class ProductViewModel
{
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public string Description { get; set; }
    public EProductStatus Status { get; set; }
    public DateTime ManufacturingDate { get; set; }
    public DateTime ExpiryDate { get; set; }
    public Guid SupplierId { get; set; }
    public string SupplierDescription { get; set; }
    public string SupplierCnpj { get; set; }
}