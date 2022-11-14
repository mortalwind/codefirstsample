using CodeFirstSample.Abstractions;
using CodeFirstSample.Models;

using System.Linq.Expressions;

namespace CodeFirstSample.Services;

public class AuthorService : IAuthorService
{
    private readonly IRepository<Author> _repository;
    public AuthorService(IRepository<Author> repository)
    {
        _repository = repository;
    }

    public async Task<Author?> AddAuthorAsync(Author Author)
    {
        return await _repository.CreateAsync(Author);
    }

    public async Task<IEnumerable<Author>> FindAuthorsAsync(Expression<Func<Author, bool>> expression)
    {
        return await _repository.GetWithQueryAsync(expression);
    }

    public async Task<Author?> GetAuthorAsync(int id)
    {
        return await _repository.DetailAsync(id);
    }

    public async Task<IEnumerable<Author>> GetAuthorsAsync()
    {
        return await _repository.GetAllAsync(); 
    }

    public async Task<Author?> UpdateAuthorAsync(Author Author)
    {
        if (await _repository.UpdateAsync(Author)) {
            return await _repository.DetailAsync(Author.ID);
        }

        return null;
    }
}
