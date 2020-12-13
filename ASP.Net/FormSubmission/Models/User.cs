using System.ComponentModel.DataAnnotations;

namespace FormSubmission.Models
{
    public class User
    {
        [Required(ErrorMessage = "First Name is Required."), MinLength(4, ErrorMessage = "Must be at least 4 or more characters."), Display(Name = "First Name:")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is Required."), MinLength(4, ErrorMessage = "Must be at least 4 or more characters."), Display(Name = "Last Name:")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Age is Required."), Range(1, 120, ErrorMessage = "Must be alive!"), Display(Name = "Age:")]
        public int? Age { get; set; }

        [Required(ErrorMessage = "Email is Required."), EmailAddress, Display(Name = "Email:")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is Required."), MinLength(8, ErrorMessage = "Must be at least 8 or more characters."), DataType(DataType.Password), Display(Name = "Password:")]
        public string Password { get; set; }
    }
}