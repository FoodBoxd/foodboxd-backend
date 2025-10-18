using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace foodboxd_backend.Models
{
    public class Rating
    {
        public int RatingId { get; set; }
        [Required]
        public int Score { get; set; }
        public DateTime CreatedAt { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
        public int DishId { get; set; }
        public Dish Dish { get; set; }
    }
}