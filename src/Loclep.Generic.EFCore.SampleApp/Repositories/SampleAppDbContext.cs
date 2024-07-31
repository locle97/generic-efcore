using Microsoft.EntityFrameworkCore;
using Loclep.Generic.EFCore.SampleApp.Domains;

namespace Loclep.Generic.EFCore.SampleApp.Repositories;

public class SampleAppDbContext: DbContext
{
  public DbSet<Product> Products { get; set; }

  public SampleAppDbContext(DbContextOptions<SampleAppDbContext> options): base(options)
  {
  }

  public SampleAppDbContext()
  {
  }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseSqlite("Data Source=D:\\dbsample.db");
  }
}
