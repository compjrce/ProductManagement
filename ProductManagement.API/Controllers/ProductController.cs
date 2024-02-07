using Microsoft.AspNetCore.Mvc;
using ProductManagement.Application.Services.Interfaces;
using ProductManagement.Domain.Entities;

namespace ProductManagement.API.Controllers;

[ApiController]
[Route("products")]
public class ProductController : ControllerBase
{
    private readonly IProductService _service;

    public ProductController(IProductService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _service.GetAll());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        return Ok(await _service.GetById(id));
    }

    [HttpPost]
    public async Task<IActionResult> Post(Product product)
    {
        await _service.Create(product);

        return Created($"products/{product.Id}", product);
    }

    [HttpPut]
    public async Task<IActionResult> Put(Guid id, Product product)
    {
        await _service.Update(id, product);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        await _service.Delete(id);

        return NoContent();
    }
}