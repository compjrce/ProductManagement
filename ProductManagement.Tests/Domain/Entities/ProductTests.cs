using ProductManagement.Domain.Entities;
using ProductManagement.Domain.Enum;

namespace ProductManagement.Tests.Domain.Entities;

public class ProductTests
{
    [Fact]
    public void CanCreateProduct()
    {
        string description = "Test Product";
        EProductStatus status = EProductStatus.Active;
        DateTime manufacturingDate = DateTime.Now.AddDays(-10);
        DateTime expiryDate = DateTime.Now.AddDays(20);
        Guid supplierId = Guid.NewGuid();
        string supplierDescription = "Test Supplier";
        string supplierCnpj = "12345678901234";

        Product product = new Product(description, status, manufacturingDate, expiryDate, supplierId, supplierDescription, supplierCnpj);

        Assert.NotNull(product);
        Assert.Equal(description, product.Description);
        Assert.Equal(status, product.Status);
        Assert.Equal(manufacturingDate, product.ManufacturingDate);
        Assert.Equal(expiryDate, product.ExpiryDate);
        Assert.Equal(supplierId, product.SupplierId);
        Assert.Equal(supplierDescription, product.SupplierDescription);
        Assert.Equal(supplierCnpj, product.SupplierCnpj);
    }
}