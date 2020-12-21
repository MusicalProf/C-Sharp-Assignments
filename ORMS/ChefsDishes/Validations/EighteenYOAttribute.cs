using System;
using System.ComponentModel.DataAnnotations;

namespace ChefsDishes.Models
{
    public class EighteenYOAttribute : ValidationAttribute
    {
        private DateTime dob;

        public string GetErrorMessage () => "Chef must be 18 years or older.";

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is DateTime) 
            {
                if((DateTime)value > DateTime.Now.AddYears(-18))
                {
                    return new ValidationResult(GetErrorMessage());
                }
                return ValidationResult.Success;
            }
            return new ValidationResult("Invalid DateTime.");
        }
    }
}