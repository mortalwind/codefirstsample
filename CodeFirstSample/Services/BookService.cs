using CodeFirstSample.Abstractions;
using CodeFirstSample.Models;

using System.Linq.Expressions;

namespace CodeFirstSample.Services;

public class BookService : IBookService
{
    private readonly IRepository<Book> _repository;
    public BookService(IRepository<Book> repository)
    {
        _repository = repository;
    }

    public async Task<Book?> AddBookAsync(Book book)
    {
        return await _repository.CreateAsync(book);
    }

    public async Task<IEnumerable<Book>> FindBooksAsync(Expression<Func<Book, bool>> expression)
    {
        return await _repository.GetWithQueryAsync(expression);
    }

    public async Task<Book?> GetBookAsync(int id)
    {
        return await _repository.DetailAsync(id);
    }

    public async Task<IEnumerable<Book>> GetBooksAsync()
    {
        return await _repository.GetAllAsync(); 
    }

    public async Task<Book?> UpdateBookAsync(Book book)
    {
        if (await _repository.UpdateAsync(book)) {
            return await _repository.DetailAsync(book.ID);
        }

        return null;
    }
}
