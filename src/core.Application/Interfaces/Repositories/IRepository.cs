namespace core.Application.Interfaces.Repositories;

public interface IRepository<TEntity> where TEntity : class
{
    Task<TEntity?> GetByIdAsync(params object[] keyValues);

    Task<List<TEntity>> GetAllAsync();

    Task AddAsync(TEntity entity);

    void Update(TEntity entity);

    void Delete(TEntity entity);
}