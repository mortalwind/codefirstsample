using CodeFirstSample.Data;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstSample.Models;

public class Author: BaseEntity
{
    public Author()
    {
        // Burası aynı kitaptan bir daha eklenmemsini garanti edecek
        this.Books = new HashSet<Book>();
    }

    [Required]
    [StringLength(200)]
    public string FullName { get; set; }


    public string? Photo { get; set; }

    public virtual ICollection<Book> Books { get; set; }
}
