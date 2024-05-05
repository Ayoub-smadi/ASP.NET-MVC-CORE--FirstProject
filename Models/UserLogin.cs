using System;
using System.Collections.Generic;

namespace FinalMVC.Models;

public partial class UserLogin
{
    public decimal Id { get; set; }

    public string? UserName { get; set; }

    public decimal? RoleId { get; set; }

    public decimal? CustomerId { get; set; }

    public string? Password { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Role? Role { get; set; }
}
