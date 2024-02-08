using ProductManagement.Domain.Enum;
using ProductManagement.Domain.Notifications;
using ProductManagement.Domain.Validations;

namespace ProductManagement.Domain.Entities;

public class Product : BaseEntity
{
    List<Notification> _notifications;
    public Product(string description, EProductStatus status, DateTime manufacturingDate, DateTime expiryDate, Guid supplierId, string supplierDescription, string supplierCnpj)
    {
        Description = description;
        Status = status;
        ManufacturingDate = manufacturingDate;
        ExpiryDate = expiryDate;
        SupplierId = supplierId;
        SupplierDescription = supplierDescription;
        SupplierCnpj = supplierCnpj;
        _notifications = new List<Notification>();
    }

    public string Description { get; private set; }
    public EProductStatus Status { get; private set; }
    public DateTime ManufacturingDate { get; private set; }
    public DateTime ExpiryDate { get; private set; }
    public Guid SupplierId { get; private set; }
    public string SupplierDescription { get; private set; }
    public string SupplierCnpj { get; private set; }
    public IReadOnlyCollection<Notification> Notifications => _notifications;

    public void DeactivateProduct()
    {
        Status = EProductStatus.Inactive;
    }

    public void UpdateProduct(string description, EProductStatus status, DateTime manufacturingDate, DateTime expiryDate, Guid supplierId, string supplierDescription, string supplierCnpj)
    {
        Description = description;
        Status = status;
        ManufacturingDate = manufacturingDate;
        ExpiryDate = expiryDate;
        SupplierId = supplierId;
        SupplierDescription = supplierDescription;
        SupplierCnpj = supplierCnpj;
    }

    public void PullNotification(Notification notification)
    {
        this._notifications.Add(notification);
    }

    public bool IsValid()
    {
        return
            new ProductValidations(this).ManufacturingDateLessThanExpiryDate().IsValid();
    }
}