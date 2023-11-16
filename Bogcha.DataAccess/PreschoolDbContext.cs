using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Bogcha.DataAccess;
public class PreschoolDbContext : DbContext
{
    public PreschoolDbContext(DbContextOptions<PreschoolDbContext> options) : base(options) { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetCallingAssembly());
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseLazyLoadingProxies();
    }
}
