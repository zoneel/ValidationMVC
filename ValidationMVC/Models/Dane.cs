using System.ComponentModel.DataAnnotations;

namespace ValidationMVC.Models;
public class Dane
{
    [Required(ErrorMessage = "Prosze podaj Imie")]
    [MinLength(2)]
    public string Imie { get; set; }
    
    [Required(ErrorMessage = "Prosze podaj Nazwisko")]
    [MinLength(2)]
    public string Nazwisko { get; set; }
    
    [Required(ErrorMessage = "Prosze podaj Email")]
    [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
    [EmailAddress]
    public string Email { get; set; }
    
    [Required(ErrorMessage = "Password is required.")]
    [MinLength(8, ErrorMessage = "Password must be at least 8 characters long.")]
    [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).+$", ErrorMessage = "Password must contain at least one digit, one lowercase letter, and one uppercase letter.")]
    public string Haslo { get; set; }
    
    [Required(ErrorMessage = "Confirm Password is required.")]
    [Compare("Haslo", ErrorMessage = "The password and confirmation password do not match.")]
    public string PotwierdzHaslo { get; set; }

    [Phone(ErrorMessage = "Invalid phone number format.")]
    public string NumerTelefonu { get; set; }

    [Required(ErrorMessage = "Age is required.")]
    [Range(10, 80, ErrorMessage = "Age must be between 10 and 80.")]
    public int Wiek { get; set; }

    [Required(ErrorMessage = "City is required.")]
    public Miasto Miasto { get; set; }
}