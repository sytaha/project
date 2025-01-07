using System.ComponentModel.DataAnnotations;

public class RegisterModel
{
    [Required(ErrorMessage = "First Name is required")]
    [StringLength(50, ErrorMessage = "First Name cannot be longer than 50 characters")]
    public string? FirstName { get; set; }

    [Required(ErrorMessage = "Last Name is required")]
    [StringLength(50, ErrorMessage = "Last Name cannot be longer than 50 characters")]
    public string? LastName { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Password is required")]
    [StringLength(100, MinimumLength = 4, ErrorMessage = "Password must be at least 6 characters long")]
    public string? Password { get; set; }

    [Required(ErrorMessage = "Confirm Password is required")]
    [Compare("Password", ErrorMessage = "Password and Confirmation Password do not match")]
    public string ?ConfirmPassword { get; set; }
}