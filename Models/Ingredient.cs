using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace foodboxd_backend.Models
{
    public class Ingredient
    {
        public int IngredientId { get; set; }
        [Required, MaxLength(30)]
        public string Name { get; set; }

        public ICollection<RecipeIngredient> RecipeIngredients { get; set; }
    }
}