
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Domain;

[Table("Genres")]
public class Genre : EntityBase
{    
    public string? Name { get; set; }
}