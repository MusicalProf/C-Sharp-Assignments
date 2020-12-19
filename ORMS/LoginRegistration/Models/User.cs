using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginRegistration.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required(ErrorMessage = "First name is required"), Display(Name = "First Name:"), MinLength(2, ErrorMessage = "First Name must be 2 or more characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required"), Display(Name = "Last Name:"), MinLength(2, ErrorMessage = "Last Name must be 2 or more characters.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required"), Display(Name = "Email:"), EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required"), Display(Name = "Password:"), MinLength(8, ErrorMessage = "Password must be 8 or more characters."), DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required"), Display(Name = "Confirm Password:"), MinLength(8, ErrorMessage = "Password must be 8 or more characters."), DataType(DataType.Password), Compare("Password"), NotMapped]
        public string Confirm { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}