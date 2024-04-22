using System.ComponentModel.DataAnnotations;

namespace club_dna_challenge.Models;

public class LoginData
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    
    [Required]
    public string Password { get; set; }
}