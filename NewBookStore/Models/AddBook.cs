using System.ComponentModel.DataAnnotations;

namespace NewBookStore.Models;

public class AddBook
{
    [Required]
    public required string Name { get; set; }
    [Required]
    public string Author {  get; set; }
    public int GenreId {  get; set; }
    public string? PublishingHouse { get; set; }
    public int YearOfPublication {  get; set; }
    public string? Description { get; set; }

}

