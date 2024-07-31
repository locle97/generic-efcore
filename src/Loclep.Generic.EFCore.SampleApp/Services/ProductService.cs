using Loclep.Generic.EFCore.SampleApp.Repositories;
using Loclep.Generic.EFCore.SampleApp.Domains;

namespace Loclep.Generic.EFCore.SampleApp.Services;

public class ProductService: IProductService
{
  private readonly IProductRepository _productRepository;
  public ProductService(IProductRepository productRepository)
  {
    _productRepository = productRepository;
  }

  public async Task<IEnumerable<Product>> GetAllProducts()
  {
    return await _productRepository.GetAll();
  }

  public async Task<Product> GetProductById(int id)
  {
    return await _productRepository.GetById(id);
  }

  public async Task<Product> CreateProduct(Product product)
  {
    return await _productRepository.Create(product);
  }

  public async Task<Product> UpdateProduct(Product product)
  {
    return await _productRepository.Update(product);
  }

  public async Task DeleteProduct(int id)
  {
    var product = await _productRepository.GetById(id);
    if (product == null)
      throw new Exception("Product not found");
       
    await _productRepository.Delete(id);
  }
}
