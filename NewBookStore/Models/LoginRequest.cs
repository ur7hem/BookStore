using System.ComponentModel.DataAnnotations;

namespace NewBookStore.Models;

public class LoginRequest
{
    [Required]
    [MinLength(3)]
    public required string Email { get; set; }

    [Required]
    [MinLength(3)]
    public required string Password { get; set; }
}
