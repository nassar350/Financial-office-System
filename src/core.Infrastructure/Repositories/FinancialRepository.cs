using core.Application.Interfaces.Repositories;
using core.Domain.Entities;
using core.Infrastructure.Persistence;

namespace core.Infrastructure.Repositories;

public class FinancialRepository : Repository<Financial>, IFinancialRepository
{
    public FinancialRepository(AppDbContext context)
        : base(context)
    {
    }
}