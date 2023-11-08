using LibraryManagement.Domain;
using LibraryManagement.Infrastructure;

namespace LibraryManagement.Application;

public class BookService : IBookService
{
    private readonly IBookRepository _bookRepository;

    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public async Task<Book> CreateBookAsync(Book book)
    {
        await _bookRepository.AddAsync(book);
        return book;
    }

    public async Task<IReadOnlyList<Book>>  GetBookAsync() => await _bookRepository.GetAllAsync();

    public async Task<Book> GetBookAsync(int id) => await _bookRepository.GetByIdAsync(id);

    public async Task<bool> RemoveBookAsync(int id)
    {
        var book = await _bookRepository.GetByIdAsync(id);
        await _bookRepository.DeleteAsync(book);
        return true;
    }

    public async Task<Book> UpdateBookAsync(int id, Book book)
    {
        var existingBook = await _bookRepository.GetByIdAsync(id);
        if(existingBook is not null)
            await _bookRepository.UpdateAsync(book);            
        return book;
    }
}
