using System.ComponentModel.DataAnnotations;

namespace NewBookStore.Models;

public class OneBook
{
    [Required]
    public required int BookId { get; set; }
}

