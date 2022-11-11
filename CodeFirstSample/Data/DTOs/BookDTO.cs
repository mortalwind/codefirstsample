namespace CodeFirstSample.Data;

public class BookDTO
{

    public string Title { get; set; }

    public string ISBN { get; set; }

    public int PublishYear { get; set; }

    public string? CoverPath { get; set; }

    public decimal Price { get; set; }

    public int AuthorId { get; set; }

}
