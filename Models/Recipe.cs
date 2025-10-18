using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace foodboxd_backend.Models
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        [Required]
        public string Instructions { get; set; }

        public int DishId { get; set; }
        [ForeignKey(nameof(DishId))]
        public Dish Dish { get; set; }

        public ICollection<RecipeIngredient> RecipeIngredients { get; set; }
    }
}