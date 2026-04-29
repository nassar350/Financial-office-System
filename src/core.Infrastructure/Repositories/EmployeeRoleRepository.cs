using core.Application.Interfaces.Repositories;
using core.Domain.Entities;
using core.Infrastructure.Persistence;

namespace core.Infrastructure.Repositories;

public class EmployeeRoleRepository : Repository<EmployeeRole>, IEmployeeRoleRepository
{
    public EmployeeRoleRepository(AppDbContext context)
        : base(context)
    {
    }
}