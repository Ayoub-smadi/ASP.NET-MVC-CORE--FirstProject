using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FinalMVC.Models;

public partial class Customer
{
    public decimal Id { get; set; }
    [DisplayName("First Name")]
    public string? Fname { get; set; }
    [DisplayName("Last Name")]
    public string? Lname { get; set; }
    [DisplayName("Image Path")]
    public string? ImagePath { get; set; }

    public virtual ICollection<ProductCustomer> ProductCustomers { get; set; } = new List<ProductCustomer>();

    public virtual ICollection<UserLogin> UserLogins { get; set; } = new List<UserLogin>();
}
