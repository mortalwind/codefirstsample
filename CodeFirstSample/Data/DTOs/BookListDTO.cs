namespace CodeFirstSample.Data;

public class BookListDTO
{
    public int ID { get; set; }

    public string Title { get; set; }

    public string? CoverPath { get; set; }

    public decimal Price { get; set; }

    public string Author { get; set; }
}
