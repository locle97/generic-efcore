using Loclep.Generic.EFCore.SampleApp.Domains;

namespace Loclep.Generic.EFCore.SampleApp.Services;

public interface IProductService
{
  Task<IEnumerable<Product>> GetAllProducts();
  Task<Product> GetProductById(int id);
  Task<Product> CreateProduct(Product product);
  Task<Product> UpdateProduct(Product product);
  Task DeleteProduct(int id);
}
