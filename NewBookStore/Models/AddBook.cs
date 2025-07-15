using System.ComponentModel.DataAnnotations;

namespace NewBookStore.Models;

public class AddBook
{
    [Required]
    public required string Name { get; set; }
    [Required]
    public int Author {  get; set; }
    public int Genre {  get; set; }
    public string? PublishingHouse { get; set; }
    public string? YearOfPublication {  get; set; }
    public string? Description { get; set; }

}

