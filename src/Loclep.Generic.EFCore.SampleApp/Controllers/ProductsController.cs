using Microsoft.AspNetCore.Mvc;
using Loclep.Generic.EFCore.SampleApp.Domains;
using Loclep.Generic.EFCore.SampleApp.Services;

namespace Loclep.Generic.EFCore.SampleApp.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class ProductsController : ControllerBase
{
  private readonly IProductService _productService;
  public ProductsController(IProductService productService)
  {
    _productService = productService;
  }

  [HttpGet(Name = "GetProducts")]
  public async Task<IActionResult> Get()
  {
    var result = await _productService.GetAllProducts();
    return Ok(result);
  }

  [HttpGet("{id}", Name = "GetProduct")]
  public async Task<IActionResult> Get(int id)
  {
    var result = await _productService.GetProductById(id);
    if (result == null)
      return NotFound();

    return Ok(result);
  }

  [HttpPost(Name = "CreateProduct")]
  public async Task<IActionResult> Post(Product product)
  {
    var result = await _productService.CreateProduct(product);
    return CreatedAtRoute("GetProduct", new { id = result.Id }, result);
  }

  [HttpPut("{id}", Name = "UpdateProduct")]
  public async Task<IActionResult> Put(int id, Product product)
  {
    product.Id = id;

    var result = await _productService.UpdateProduct(product);
    if (result == null)
      return NotFound();

    return Ok(result);
  }

  [HttpDelete("{id}", Name = "DeleteProduct")]
  public async Task<IActionResult> Delete(int id)
  {
    await _productService.DeleteProduct(id);
    return Ok();
  }
}
