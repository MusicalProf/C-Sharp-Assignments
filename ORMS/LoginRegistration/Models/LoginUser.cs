using System.ComponentModel.DataAnnotations;

namespace LoginRegistration.Models
{
    public class LoginUser
    {
        [Required(ErrorMessage = "Please enter your email."), EmailAddress, Display(Name="Email:")]
        public string LEmail { get; set; }

        [Required(ErrorMessage ="Please enter your password."), DataType(DataType.Password), Display(Name="Password:")]
        public string LPassword { get; set; }
    }
}