using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace foodboxd_backend.Models
{
    public class Favorite
    {
        [Key, Column(Order = 0)]
        public int UserId { get; set; }
        [Key, Column(Order = 1)]
        public int DishId { get; set; }

        public User User { get; set; }
        public Dish Dish { get; set; }
    }
}