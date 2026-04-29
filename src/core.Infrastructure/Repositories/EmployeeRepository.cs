using core.Application.Interfaces.Repositories;
using core.Domain.Entities;
using core.Infrastructure.Persistence;

namespace core.Infrastructure.Repositories;

public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
{
    public EmployeeRepository(AppDbContext context)
        : base(context)
    {
    }
}