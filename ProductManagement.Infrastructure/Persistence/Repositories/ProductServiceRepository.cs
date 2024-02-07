using Microsoft.EntityFrameworkCore;
using ProductManagement.Domain.Entities;
using ProductManagement.Domain.Repositories;

namespace ProductManagement.Infrastructure.Persistence.Repositories;

public class ProductServiceRepository : IProductServiceRepository
{
    private readonly ProductDbContext _context;

    public ProductServiceRepository(ProductDbContext context)
    {
        _context = context;
    }

    public async Task Create(Product product)
    {
        try
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            Task.CompletedTask.Wait();
        }
        catch (Exception ex)
        {
            _ = Task.FromException(ex);
        }
    }

    public async Task Delete(Guid id)
    {
        var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == id);

        if (product == null)
            return;

        try
        {
            product.DeactivateProduct();

            _context.Products.Update(product);
            await _context.SaveChangesAsync();
            Task.CompletedTask.Wait();
        }
        catch (Exception ex)
        {
            _ = Task.FromException(ex);
        }
    }

    public async Task<List<Product>> GetAll()
    {
        var products = await _context
            .Products
            .AsNoTracking()
            .ToListAsync();

        return products;
    }

    public async Task<Product> GetById(Guid id)
    {
        var product = await _context
            .Products
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id);

        return product;
    }

    public async Task Update(Guid id, Product product)
    {
        var currentProduct = await _context.Products.FirstOrDefaultAsync(x => x.Id == id);

        if (currentProduct == null)
            return;

        try
        {
            currentProduct.UpdateProduct(product.Description, product.Status, product.ManufacturingDate, product.ExpiryDate, product.SupplierId, product.SupplierDescription, product.SupplierCnpj);

            _context.Update(currentProduct);
            await _context.SaveChangesAsync();
            Task.CompletedTask.Wait();
        }
        catch (Exception ex)
        {
            _ = Task.FromException(ex);
        }
    }
}