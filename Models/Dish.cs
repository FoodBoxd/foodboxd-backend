using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace foodboxd_backend.Models
{
    public class Dish
    {
        public int DishId { get; set; }
        [Required, MaxLength(30)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public byte[] Photo { get; set; }

        public Recipe Recipe { get; set; }
        public ICollection<Publication> Publications { get; set; }
        public ICollection<Rating> Ratings { get; set; }
        public ICollection<Favorite> Favorites { get; set; }
    }
}