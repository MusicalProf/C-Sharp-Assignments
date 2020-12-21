using System;
using System.ComponentModel.DataAnnotations;

namespace ChefsDishes.Models
{
    public class Dish
    {
        [Key]
        public int DishID { get; set; }

        [Required(ErrorMessage = "Name of Dish is Required."), MinLength(2, ErrorMessage = "Name of Dish must be 2 characters or more."), Display(Name = "Name of Dish:")]
        public string NameOfDish { get; set; }

        [Required(ErrorMessage = "Calories are required."), Range(1, 5000, ErrorMessage = "Invalid number of calories."), Display(Name = "Calories:")]
        public int? Calories { get; set; }

        [Required(ErrorMessage = "Please select a tastiness value."), Range(1, 5, ErrorMessage = "Invalid tastiness value."), Display(Name = "Tastiness")]
        public int? Tastiness { get; set; }

        [Required(ErrorMessage = "Please enter a description."), MinLength(10, ErrorMessage = "Description must be 10 or more characters."), Display(Name = "Description:")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please choose a chef."), Display(Name = "Chefs:")]
        public int ChefID { get; set; }

        public Chef Creator { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}