using System;
using System.ComponentModel.DataAnnotations;

namespace CRUDelicious.Models
{
    public class Dish
    {
        [Key]
        public int DishID { get; set; }

        [Required(ErrorMessage = "Give your dish a name please."), Display(Name = "Name of Dish:")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The dish needs a Chef's name."), Display(Name = "Chef Name:")]
        public string Chef { get; set; }

        [Required(ErrorMessage = "Choose a tastiness level please!"), Display(Name = "Tastiness"), Range(1, 5)]
        public int? Tastiness { get; set; }

        [Required(ErrorMessage = "Calories is a required field."), Display(Name = "# of Calories:"), Range(1, 5000)]
        public int? Calories { get; set; }

        [Required(ErrorMessage = "Please enter a description of your dish.")]
        public string Description { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}