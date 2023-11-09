using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Domain;

[Table("Branchs")]
public class Branch : EntityBase
{    
    public string? Name { get; set; }
    public string? Address {  get; set; }
    public string? State { get; set; }
    public string? Country { get; set; }
    public string? PostalCode { get; set; }
}