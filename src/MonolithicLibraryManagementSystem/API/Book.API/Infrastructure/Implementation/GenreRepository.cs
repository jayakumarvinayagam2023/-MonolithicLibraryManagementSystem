
using LibraryManagement.Domain;

namespace LibraryManagement.Infrastructure;
public class GenreRepository : RepositoryBase<Genre>, IGenreRepository
{
    public GenreRepository(BookDbContext dbContext) : base(dbContext)
    {
        
    }
}