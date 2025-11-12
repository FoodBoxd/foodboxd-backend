using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace foodboxd_backend.Models
{
    public class RatingLike
    {
        [Key, Column(Order = 0)]
        public int UserId { get; set; }
        public User User { get; set; }

        [Key, Column(Order = 1)]
        public int RatingId { get; set; }
        public Rating Rating { get; set; }
    }
}