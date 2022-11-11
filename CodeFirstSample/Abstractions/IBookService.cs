using CodeFirstSample.Models;

using System.Linq.Expressions;

namespace CodeFirstSample.Abstractions;

public interface IBookService
{
    /// <summary>
    /// Gets a book detail with th ID.
    /// </summary>
    /// <param name="id">Book ID</param>
    /// <returns></returns>
    Task<Book?> GetBookAsync(int id);


    /// <summary>
    /// Gets all books
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<Book>> GetBooksAsync();

    /// <summary>
    /// Finds books with expression
    /// </summary>
    /// <param name="expression">Search expressions</param>
    /// <returns></returns>
    Task<IEnumerable<Book>> FindBooksAsync(Expression<Func<Book, bool>> expression);

    /// <summary>
    /// Adds a new book
    /// </summary>
    /// <param name="book">Book data</param>
    /// <returns></returns>
    Task<Book?> AddBookAsync(Book book);


    /// <summary>
    /// Updates an exisist book 
    /// </summary>
    /// <param name="book">Book data</param>
    /// <returns></returns>
    Task<Book?> UpdateBookAsync(Book book);
}
