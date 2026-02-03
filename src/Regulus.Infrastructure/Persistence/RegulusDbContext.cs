using Microsoft.EntityFrameworkCore;
using Regulus.Domain.Entities;

namespace Regulus.Infrastructure.Persistence;

public class RegulusDbContext : DbContext
{
    public RegulusDbContext(DbContextOptions<RegulusDbContext> options) : base(options)
    {
    }

    public DbSet<Operator> Operators { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(RegulusDbContext).Assembly);
    }
}
