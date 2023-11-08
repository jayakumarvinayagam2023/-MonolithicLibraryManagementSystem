
using LibraryManagement.Domain;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Infrastructure;
public class AuthorRepository : RepositoryBase<Author>, IAuthorRepository
{
    public AuthorRepository(BookDbContext dbContext) : base(dbContext)
    {
        
    }
    public async Task<IEnumerable<Author>> GetUsersByFirstName(string name)
    {
        var authors = await _dbContext.Authors
            .Where(_ => _.FirstName == name)
            .ToListAsync();
        return authors;
    }
}