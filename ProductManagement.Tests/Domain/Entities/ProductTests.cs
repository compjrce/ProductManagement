using ProductManagement.Domain.Entities;
using ProductManagement.Domain.Enum;
using Shouldly;

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

        product.ShouldNotBeNull();
        product.CreatedAt.ShouldBeLessThanOrEqualTo(DateTime.Now);
        product.Description.ShouldBeEquivalentTo(description);
        product.Status.ShouldBeEquivalentTo(status);
        product.ManufacturingDate.ShouldBeEquivalentTo(manufacturingDate);
        product.ExpiryDate.ShouldBeEquivalentTo(expiryDate);
        product.SupplierId.ShouldBeEquivalentTo(supplierId);
        product.SupplierDescription.ShouldBeEquivalentTo(supplierDescription);
        product.SupplierCnpj.ShouldBeEquivalentTo(supplierCnpj);
    }
}