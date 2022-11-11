using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstSample.Data;

public abstract class BaseEntity
{

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID { get; set; }

    public DateTime DateCreated { get; set; } = DateTime.Now;
}
