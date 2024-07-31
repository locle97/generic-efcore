using Loclep.Generic.EFCore.SampleApp.Domains;
using Loclep.Generic.EFCore;

namespace Loclep.Generic.EFCore.SampleApp.Repositories
{
  public interface IProductRepository: IBaseRepository<Product, int>
  {
  }
}
