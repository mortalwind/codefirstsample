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

    private readonly IAuthorService _authorService;

    private readonly IMapper _mapper;
    public AuthorsController(IAuthorService authorService, IMapper mapper)
    {
        _authorService = authorService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IEnumerable<AuthorListDTO>> GetAuthorsAsync()
    {

        var authors = await _authorService.GetAuthorsAsync();

        return _mapper.Map<List<AuthorListDTO>>(authors);

    }

    [HttpPost]
    public async Task<AuthorDTO> AddAuthorAsync([FromBody]AuthorDTO  author)
    {

        var newAuthor = await _authorService.AddAuthorAsync(_mapper.Map<Author>(author));

        return _mapper.Map<AuthorDTO>(newAuthor);

    }
}
