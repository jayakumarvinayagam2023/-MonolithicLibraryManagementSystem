using LibraryManagement.Domain;
using LibraryManagement.Infrastructure;

namespace LibraryManagement.Application;

public class AuthorService : IAuthorService
{
    private readonly IAuthorRepository _AuthorRepository;

    public AuthorService(IAuthorRepository AuthorRepository)
    {
        _AuthorRepository = AuthorRepository;
    }

    public async Task<Author> CreateAuthorAsync(Author Author)
    {
        await _AuthorRepository.AddAsync(Author);
        return Author;
    }

    public async Task<IReadOnlyList<Author>>  GetAuthorAsync() => await _AuthorRepository.GetAllAsync();

    public async Task<Author> GetAuthorAsync(int id) => await _AuthorRepository.GetByIdAsync(id);

    public async Task<bool> RemoveAuthorAsync(int id)
    {
        var Author = await _AuthorRepository.GetByIdAsync(id);
        await _AuthorRepository.DeleteAsync(Author);
        return true;
    }

    public async Task<Author> UpdateAuthorAsync(int id, Author Author)
    {
        var existingAuthor = await _AuthorRepository.GetByIdAsync(id);
        if(existingAuthor is not null)
            await _AuthorRepository.UpdateAsync(Author);            
        return Author;
    }
}
