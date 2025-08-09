﻿using System.ComponentModel.DataAnnotations;

namespace NewBookStore.Models;

public class AddUser
{
    [Required]
    public required string UserName { get; set; }
    [Required]
    public required string Email { get; set; }
    [Required]
    public required string Password { get; set; }

}

