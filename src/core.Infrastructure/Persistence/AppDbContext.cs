using core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace core.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Role> Roles => Set<Role>();

    public DbSet<Employee> Employees => Set<Employee>();

    public DbSet<EmployeePhone> EmployeePhones => Set<EmployeePhone>();

    public DbSet<Client> Clients => Set<Client>();

    public DbSet<ClientPhone> ClientPhones => Set<ClientPhone>();

    public DbSet<Financial> Financials => Set<Financial>();

    public DbSet<Tasks> Tasks => Set<Tasks>();

    public DbSet<EmployeeRole> EmployeeRoles => Set<EmployeeRole>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}