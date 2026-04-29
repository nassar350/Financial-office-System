using core.Application.Interfaces.Repositories;
using core.Domain.Entities;
using core.Infrastructure.Persistence;

namespace core.Infrastructure.Repositories;

public class TasksRepository : Repository<Tasks>, ITasksRepository
{
    public TasksRepository(AppDbContext context)
        : base(context)
    {
    }
}