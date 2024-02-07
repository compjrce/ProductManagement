using ProductManagement.Domain.Entities;
using ProductManagement.Domain.Notifications;
using ProductManagement.Domain.Validations.Interfaces;

namespace ProductManagement.Domain.Validations;

public class ProductValidations : IValidate
{
    private readonly Product _product;

    public ProductValidations(Product product)
    {
        this._product = product;
    }

    public ProductValidations ManufacturingDateLessThanExpiryDate()
    {
        if (_product.ManufacturingDate.Date >= _product.ExpiryDate.Date)
            _product.PullNotification(
                new Notification(
                    "ManufacturingDate", "Manufacturing must be less than Expiry Date"));

        return this;
    }

    public bool IsValid()
    {
        return (_product.Notifications.Count == 0 ? true : false);
    }
}