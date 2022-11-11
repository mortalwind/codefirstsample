using CodeFirstSample.Models;

using Microsoft.EntityFrameworkCore;

namespace CodeFirstSample.Data;

public class ApplicationDbContext : DbContext
{

    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base (options)
	{
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Book>()
			.HasOne(r => r.Author)
			.WithMany(r => r.Books);
	}
}
