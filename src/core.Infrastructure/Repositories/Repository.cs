using core.Application.Interfaces.Repositories;
using core.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace core.Infrastructure.Repositories;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    protected readonly AppDbContext Context;
    protected readonly DbSet<TEntity> Entities;

    public Repository(AppDbContext context)
    {
        Context = context;
        Entities = context.Set<TEntity>();
    }

    public Task<TEntity?> GetByIdAsync(params object[] keyValues)
    {
        return Entities.FindAsync(keyValues).AsTask();
    }

    public async Task<List<TEntity>> GetAllAsync()
    {
        return await Entities.ToListAsync();
    }

    public async Task AddAsync(TEntity entity)
    {
        await Entities.AddAsync(entity);
    }

    public void Update(TEntity entity)
    {
        Entities.Update(entity);
    }

    public void Delete(TEntity entity)
    {
        Entities.Remove(entity);
    }
}