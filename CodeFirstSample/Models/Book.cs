using CodeFirstSample.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstSample.Models;

public class Book : BaseEntity
{

    [Required]
    [StringLength(500)]
    public string Title { get; set; }


    [Required]
    [StringLength(15)]
    public string ISBN { get; set; }

    [Required]
    public int PublishYear { get; set; }

    public string? CoverPath { get; set; }

    [Required]
    [Column(TypeName = "decimal(18,4)")]
    public decimal Price { get; set; }

    public int? AuthorId { get; set; }

    public Author Author { get; set; }
}
