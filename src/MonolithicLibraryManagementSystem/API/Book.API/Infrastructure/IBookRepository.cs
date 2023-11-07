

using LibraryManagement.Domain;

namespace LibraryManagement.Infrastructure;
public interface IBookRepository :  IAsyncRepository<Book>
{
    Task<IEnumerable<Book>> GetBooksByUserName(string userName);
}