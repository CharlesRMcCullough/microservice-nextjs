using System.ComponentModel.DataAnnotations;

namespace IdentityService.Pages.Account.Register;

public class RegisterViewModel
{
    [Required]
    public string Email { get; set; } = String.Empty; 
    [Required]
    public string Password { get; set; } = String.Empty;
    [Required]
    public string Username { get; set; } = String.Empty;
    [Required]
    public string FullName { get; set; } = String.Empty;
    public string ReturnUrl { get; set; } = String.Empty;  
    public string Button { get; set; } = String.Empty;
    
    
}