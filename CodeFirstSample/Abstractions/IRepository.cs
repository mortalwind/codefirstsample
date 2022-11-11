using CodeFirstSample.Data;

using System.Linq.Expressions;

namespace CodeFirstSample.Abstractions;

/// <summary>
/// Generic repository pattern
/// We will use this interface for all repositories
/// </summary>
public interface IRepository<TEntity> where TEntity: BaseEntity
{
    /// <summary>
    /// Adds a new record.
    /// </summary>
    /// <param name="entity">New entity object</param>
    /// <returns></returns>
    TEntity Create(TEntity entity);

    /// <summary>
    /// Adds a new record asynchronously.
    /// </summary>
    /// <param name="entity">New entity object</param>
    /// <returns></returns>
    Task<TEntity> CreateAsync(TEntity entity);

    /// <summary>
    /// Adds a new record.
    /// </summary>
    /// <param name="entity">New entity object</param>
    /// <returns></returns>
    bool Update(TEntity entity);

    /// <summary>
    /// Adds a new record asynchronously.
    /// </summary>
    /// <param name="entity">New entity object</param>
    /// <returns></returns>
    Task<bool> UpdateAsync(TEntity entity);

    /// <summary>
    /// Gets a record with th id.
    /// </summary>
    /// <param name="id">Entity's ID</param>
    /// <returns></returns>
    TEntity? Detail(int id);


    /// <summary>
    /// Gets a record asynchronously with the id.
    /// </summary>
    /// <param name="id">Entity's ID</param>
    /// <returns></returns>
    Task<TEntity?> DetailAsync(int id);

    /// <summary>
    /// Gets all records.
    /// </summary>
    /// <returns></returns>
    IEnumerable<TEntity> GetAll();

    /// <summary>
    /// Gets all records asynchronously.
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<TEntity>> GetAllAsync();

    /// <summary>
    /// Gets all records with a query.
    /// </summary>
    /// <returns></returns>
    IEnumerable<TEntity> GetWithQuery(Expression<Func<TEntity, bool>> expression);

    /// <summary>
    /// Gets all records asynchronously with a query.
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<TEntity>> GetWithQueryAsync(Expression<Func<TEntity, bool>> expression);


    /// <summary>
    /// Deletes a record with the ID.
    /// </summary>
    /// <param name="entity">New entity object</param>
    /// <returns></returns>
    bool Delete(int id);

    /// <summary>
    /// Deletes a record asynchronously with the ID.
    /// </summary>
    /// <param name="entity">New entity object</param>
    /// <returns></returns>
    Task<bool> DeleteAsync(int id);
}
