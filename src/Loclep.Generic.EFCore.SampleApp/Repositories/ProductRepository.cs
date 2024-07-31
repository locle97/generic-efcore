using Loclep.Generic.EFCore;
using Loclep.Generic.EFCore.SampleApp.Domains;

namespace Loclep.Generic.EFCore.SampleApp.Repositories;

public class ProductRepository : BaseRepository<SampleAppDbContext, Product, int>, IProductRepository
{
    public ProductRepository(SampleAppDbContext dbContext) : base(dbContext)
    {
    }
}
