using Microsoft.EntityFrameworkCore;

namespace BookStoreDb.Db;

public class BookDbContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<AuthorMany> AuthorsManys { get; set; }
    public DbSet<OrderHistory> OrderHistories { get; set; }

    public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }
}
