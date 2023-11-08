using LibraryManagement.Domain;

namespace LibraryManagement.Infrastructure;
public interface IAuthorRepository :  IAsyncRepository<Author>
{
    Task<IEnumerable<Author>> GetUsersByFirstName(string name);
}