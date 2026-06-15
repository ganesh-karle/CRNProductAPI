using CRNProductAPI.Application.DTOs;
using CRNProductAPI.Application.Services;
using CRNProductAPI.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CRNProductAPI.Controllers;

[Route("api/[controller]")]
[Authorize]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IProductService _service;

    public ProductsController(IProductService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var products = await _service.GetAllProductsAsync();

        return Ok(products);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var product = await _service.GetProductByIdAsync(id);

        if (product == null)
            return NotFound();

        return Ok(product);
    }
    [HttpPost]
    public async Task<IActionResult>
    Create(CreateProductDto dto)
    {
        var result =
            await _service.CreateProductAsync(dto);

        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult>
Update(int id, UpdateProductDto dto)
    {
        var result =
            await _service.UpdateProductAsync(id, dto);

        if (!result)
            return NotFound();

        return Ok("Product Updated Successfully");
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.DeleteProductAsync(id);

        if (!result)
            return NotFound();

        return Ok("Product Deleted Successfully");
    }
}