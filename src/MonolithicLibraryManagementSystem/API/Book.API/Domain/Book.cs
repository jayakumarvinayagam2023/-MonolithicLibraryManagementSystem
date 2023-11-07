
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Domain;

[Table("Books")]
public class Book : EntityBase
{
    public string? Title { get; set; }
    public byte Rating { get; set; }
    public string? Author { get; set; }
}