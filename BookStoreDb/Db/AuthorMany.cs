using Microsoft.EntityFrameworkCore;

namespace BookStoreDb.Db;

[PrimaryKey(nameof(BookId), nameof(AuthorId))]
public class AuthorMany
{
    public int BookId { get; set; }
    public int AuthorId { get; set; }
}
