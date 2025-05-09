using System.ComponentModel.DataAnnotations;

public class Customer
{
    public int Id { get; set; }

    [Required]
    public string FullName { get; set; }

    public string Name { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    public string Address { get; set; }
}
