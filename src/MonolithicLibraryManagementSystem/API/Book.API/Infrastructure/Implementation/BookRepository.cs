
using LibraryManagement.Domain;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Infrastructure;
public class BookRepository : RepositoryBase<Book>, IBookRepository
{
    public BookRepository(BookDbContext dbContext) : base(dbContext)
    {
        
    }
    public async Task<IEnumerable<Book>> GetBooksByUserName(string userName)
    {
        var BookList = await _dbContext.Books
            .Where(_ => _.Author == userName)
            .ToListAsync();
        return BookList;

    }
}