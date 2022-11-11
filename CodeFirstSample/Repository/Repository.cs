using CodeFirstSample.Abstractions;
using CodeFirstSample.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CodeFirstSample.Repository;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
{
    private readonly ApplicationDbContext _dbContext;

    public Repository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public TEntity Create(TEntity entity)
    {
        var newEntity = _dbContext.Add(entity);

        _dbContext.SaveChanges();

        return newEntity.Entity;
    }

    public async Task<TEntity> CreateAsync(TEntity entity)
    {
        var newEntity = await _dbContext.AddAsync(entity);

        await _dbContext.SaveChangesAsync();

        return newEntity.Entity;
    }

    public bool Delete(int id)
    {
        _dbContext.Set<TEntity>().ExecuteDelete();
        var result =_dbContext.SaveChanges();
        return result > 0;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        await _dbContext.Set<TEntity>().ExecuteDeleteAsync();
        var result = await _dbContext.SaveChangesAsync();
        return result > 0;
    }

    public TEntity? Detail(int id)
    {
        return _dbContext.Set<TEntity>().SingleOrDefault(x => x.ID == id);
    }

    public async Task<TEntity?> DetailAsync(int id)
    {
        return await _dbContext.Set<TEntity>().SingleOrDefaultAsync(x => x.ID == id);
    }

    public IEnumerable<TEntity> GetAll()
    {
        return _dbContext.Set<TEntity>().AsEnumerable();
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _dbContext.Set<TEntity>().ToListAsync();
    }

    public IEnumerable<TEntity> GetWithQuery(Expression<Func<TEntity, bool>> expression)
    {
        return _dbContext.Set<TEntity>().Where(expression);
    }

    public async Task<IEnumerable<TEntity>> GetWithQueryAsync(Expression<Func<TEntity, bool>> expression)
    {
        return await _dbContext.Set<TEntity>().Where(expression).ToListAsync();
    }

    public bool Update(TEntity entity)
    {
        _dbContext.Update(entity);
        var result = _dbContext.SaveChanges();
        return result > 0;
    }

    public async Task<bool> UpdateAsync(TEntity entity)
    {
        _dbContext.Update(entity);
        var result = await _dbContext.SaveChangesAsync();
        return result > 0;
    }

}
