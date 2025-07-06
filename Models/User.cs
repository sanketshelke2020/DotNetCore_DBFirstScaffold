using System;
using System.Collections.Generic;

namespace Core_DBFirst.Models;

public partial class User
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int? Age { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public DateTime? CreatedAt { get; set; }
}
