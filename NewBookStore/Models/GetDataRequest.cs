using System.ComponentModel.DataAnnotations;

namespace NewBookStore.Models;

public class GetDataRequest
{
    [Required]
    public required string Accept {get; set;}
    [Required]
    public required string Authorization {get; set;}
}

