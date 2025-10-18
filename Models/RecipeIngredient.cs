using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace foodboxd_backend.Models
{
    public class RecipeIngredient
    {
        [Key, Column(Order = 0)]
        public int RecipeId { get; set; }
        [Key, Column(Order = 1)]
        public int IngredientId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required, MaxLength(30)]
        public string MeasurementUnit { get; set; }

        public Recipe Recipe { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}