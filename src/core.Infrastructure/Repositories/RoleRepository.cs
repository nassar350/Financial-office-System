using core.Application.Interfaces.Repositories;
using core.Domain.Entities;
using core.Infrastructure.Persistence;

namespace core.Infrastructure.Repositories;

public class RoleRepository : Repository<Role>, IRoleRepository
{
    public RoleRepository(AppDbContext context)
        : base(context)
    {
    }
}