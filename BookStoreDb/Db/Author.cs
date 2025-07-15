namespace BookStoreDb.Db;

public class Author
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public required string LastName { get; set; }
    public string? SurName { get; set; }

    public virtual required ICollection<Book> Books { get; set; }
}