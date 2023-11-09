
using LibraryManagement.Domain;

namespace LibraryManagement.Application;

public interface IGenreService
{
    Task<IReadOnlyList<Genre>> GetGenreAsync();
    Task<Genre> GetGenreAsync(int id);
    Task<Genre> CreateGenreAsync(Genre Genre);
    Task<Genre> UpdateGenreAsync(int id, Genre Genre);
    Task<bool> RemoveGenreAsync(int id);
}

