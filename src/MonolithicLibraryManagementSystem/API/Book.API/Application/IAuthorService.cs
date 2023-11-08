
using LibraryManagement.Domain;

namespace LibraryManagement.Application;

public interface IAuthorService
{
    Task<IReadOnlyList<Author>> GetAuthorAsync();
    Task<Author> GetAuthorAsync(int id);
    Task<Author> CreateAuthorAsync(Author author);
    Task<Author> UpdateAuthorAsync(int id, Author author);
    Task<bool> RemoveAuthorAsync(int id);
}

