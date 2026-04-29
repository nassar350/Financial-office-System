using core.Application.Interfaces.Repositories;
using core.Domain.Entities;
using core.Infrastructure.Persistence;

namespace core.Infrastructure.Repositories;

public class ClientPhoneRepository : Repository<ClientPhone>, IClientPhoneRepository
{
    public ClientPhoneRepository(AppDbContext context)
        : base(context)
    {
    }
}