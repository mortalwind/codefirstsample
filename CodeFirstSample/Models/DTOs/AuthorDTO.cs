namespace CodeFirstSample.Models;

public class AuthorDTO
{
    public string FullName { get; set; }

    public string? Photo { get; set; }

    public DateTime BirthDate { get; set; }

    public string? Biography { get; set; }
}