using LibraryManagement.Domain;
using LibraryManagement.Infrastructure;

namespace LibraryManagement.Application;

public class GenreService : IGenreService
{
    private readonly IGenreRepository _GenreRepository;

    public GenreService(IGenreRepository GenreRepository)
    {
        _GenreRepository = GenreRepository;
    }

    public async Task<Genre> CreateGenreAsync(Genre Genre)
    {
        await _GenreRepository.AddAsync(Genre);
        return Genre;
    }

    public async Task<IReadOnlyList<Genre>>  GetGenreAsync() => (await _GenreRepository.GetAllAsync()).OrderBy(_=> _.Name).ToList();

    public async Task<Genre> GetGenreAsync(int id) => await _GenreRepository.GetByIdAsync(id);

    public async Task<bool> RemoveGenreAsync(int id)
    {
        var Genre = await _GenreRepository.GetByIdAsync(id);
        await _GenreRepository.DeleteAsync(Genre);
        return true;
    }

    public async Task<Genre> UpdateGenreAsync(int id, Genre Genre)
    {
        var existingGenre = await _GenreRepository.GetByIdAsync(id);
        if(existingGenre is not null)
            await _GenreRepository.UpdateAsync(Genre);            
        return Genre;
    }
}
