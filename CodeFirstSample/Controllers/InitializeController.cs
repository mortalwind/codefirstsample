using CodeFirstSample.Data;
using CodeFirstSample.Models;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstSample.Controllers;
[Route("api/[controller]")]
[ApiController]
public class InitializeController : ControllerBase
{
    private readonly ApplicationDbContext _dbContext;

    public InitializeController(ApplicationDbContext dbContext)
	{
        _dbContext = dbContext;

    }

    [HttpGet]
    public async Task<ActionResult> Initiate() {

        _dbContext.Database.EnsureCreated();
        await _dbContext.Database.MigrateAsync();
        
        return Ok("Database migration is finished.");
    }

}
