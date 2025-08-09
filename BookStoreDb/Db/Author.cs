namespace BookStoreDb.Db;

public class Author : IEntity<int>
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public required string LastName { get; set; }
    public string? SurName { get; set; }

    public virtual required ICollection<Book> Books { get; set; }
}