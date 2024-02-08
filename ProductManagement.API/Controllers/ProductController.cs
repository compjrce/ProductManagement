using Microsoft.AspNetCore.Mvc;
using ProductManagement.Application.InputModels;
using ProductManagement.Application.Services.Interfaces;
using ProductManagement.Application.ViewModels;

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
    public async Task<IActionResult> GetAll([FromQuery] ProductsParametersInputModel productsParameters)
    {
        return Ok(await _service.GetAll(productsParameters));
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var produto = await _service.GetById(id);

        if (produto == null)
            return NotFound();

        return Ok(produto);
    }

    [HttpPost]
    public async Task<IActionResult> Post(ProductInputModel productInputModel)
    {
        var response = await _service.Create(productInputModel);

        if (response.Notifications.Any())
            return BadRequest(response.Notifications);

        var product = (ProductViewModel)response.Data;

        return Created($"products/{product.Id}", product);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(ProductInputModel productInputModel, Guid id)
    {
        var response = await _service.Update(id, productInputModel);

        if (response.Notifications.Any())
            return BadRequest(response.Notifications);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        await _service.Delete(id);

        return NoContent();
    }
}