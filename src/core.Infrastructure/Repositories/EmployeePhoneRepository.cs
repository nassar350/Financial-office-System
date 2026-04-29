using core.Application.Interfaces.Repositories;
using core.Domain.Entities;
using core.Infrastructure.Persistence;

namespace core.Infrastructure.Repositories;

public class EmployeePhoneRepository : Repository<EmployeePhone>, IEmployeePhoneRepository
{
    public EmployeePhoneRepository(AppDbContext context)
        : base(context)
    {
    }
}