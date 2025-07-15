//namespace NewBookStore.Models
namespace BookStoreDb.Db;

public class Book
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public int GenreId { get; set; }
    public string? PublishingHouse { get; set; }
    public int? YearOfPublication { get; set; }
}