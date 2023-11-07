
using LibraryManagement.Domain;

namespace LibraryManagement.Application;

public interface IBookService
{
    Task<IReadOnlyList<Book>> GetBookAsync();
    Task<Book> GetBookAsync(int id);
    Task<Book> CreateBookAsync(Book book);
    Task<Book> UpdateBookAsync(int id, Book book);
    Task<bool> RemoveBookAsync(int id);
}

