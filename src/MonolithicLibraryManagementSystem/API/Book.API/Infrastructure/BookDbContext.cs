using Microsoft.EntityFrameworkCore;
using LibraryManagement.Domain;

namespace LibraryManagement.Infrastructure;

public class BookDbContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("monolithic");
        BookConfiguration.Configure(modelBuilder.Entity<Book>());
        AuthorConfiguration.Configure(modelBuilder.Entity<Author>());
        base.OnModelCreating(modelBuilder);
    }

}
