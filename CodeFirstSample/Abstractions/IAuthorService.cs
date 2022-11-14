using CodeFirstSample.Models;

using System.Linq.Expressions;

namespace CodeFirstSample.Abstractions;

public interface IAuthorService
{
    /// <summary>
    /// Gets a Author detail with th ID.
    /// </summary>
    /// <param name="id">Author ID</param>
    /// <returns></returns>
    Task<Author?> GetAuthorAsync(int id);


    /// <summary>
    /// Gets all Authors
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<Author>> GetAuthorsAsync();

    /// <summary>
    /// Finds Authors with expression
    /// </summary>
    /// <param name="expression">Search expressions</param>
    /// <returns></returns>
    Task<IEnumerable<Author>> FindAuthorsAsync(Expression<Func<Author, bool>> expression);

    /// <summary>
    /// Adds a new Author
    /// </summary>
    /// <param name="Author">Author data</param>
    /// <returns></returns>
    Task<Author?> AddAuthorAsync(Author Author);


    /// <summary>
    /// Updates an exisist Author 
    /// </summary>
    /// <param name="Author">Author data</param>
    /// <returns></returns>
    Task<Author?> UpdateAuthorAsync(Author Author);
}
