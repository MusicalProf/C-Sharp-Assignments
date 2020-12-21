using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChefsDishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefID { get; set; }

        [Required(ErrorMessage = "First Name is required."), MinLength(2, ErrorMessage = "First name needs to be more than 2 characters."), Display(Name = "First Name:")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required."), MinLength(2, ErrorMessage = "Last name needs to be more than 2 characters."), Display(Name = "Last Name:")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Date of Birth is Required."), DataType(DataType.Date), Display(Name = "Date of Birth:"), EighteenYO]
        public DateTime DOB { get; set; }

        public List<Dish> AllDishes { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}