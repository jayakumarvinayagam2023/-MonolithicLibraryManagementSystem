
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Domain;

[Table("Authors")]
public class Author : EntityBase
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
}