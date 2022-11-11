using AutoMapper;

using CodeFirstSample.Abstractions;
using CodeFirstSample.Data;
using CodeFirstSample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstSample.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AuthorsController : ControllerBase
{

    private readonly IBookService _bookService;

    private readonly IMapper _mapper;
    public BooksController(IBookService bookService, IMapper mapper)
    {
        _bookService = bookService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IEnumerable<BookListDTO>> GetBooksAsync()
    {

        var books = await _bookService.GetBooksAsync();

        return _mapper.Map<List<BookListDTO>>(books);

    }
}
