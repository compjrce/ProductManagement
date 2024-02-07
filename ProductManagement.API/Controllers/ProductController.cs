using Microsoft.AspNetCore.Mvc;
using ProductManagement.Application.InputModels;
using ProductManagement.Application.Services.Interfaces;

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

    // [HttpGet]
    // public async Task<IActionResult> GetAll([FromQuery] ProductsParameters productsParameters)
    // {
    //     return Ok(await _service.GetAll(productsParameters));
    // }

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

        return Created($"products/{response.Data.Id}", response.Data);
    }

    // [HttpPut]
    // public async Task<IActionResult> Put(Guid id, Product product)
    // {
    //     if (!product.IsValid())
    //         return BadRequest(product.Notifications);

    //     await _service.Update(id, product);

    //     return NoContent();
    // }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        await _service.Delete(id);

        return NoContent();
    }
}