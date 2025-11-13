using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace foodboxd_backend.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        public byte[] ProfilePhoto { get; set; }
        [Required, MaxLength(100)]
        public string Email { get; set; }
        [JsonIgnore] 
        public byte[] PasswordHash { get; set; }
        [JsonIgnore] 
        public byte[] PasswordSalt { get; set; }

        public string Biography { get; set; }
        [Required]
        public DateOnly Birthdate { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<Rating> Ratings { get; set; }
        public ICollection<Favorite> Favorites { get; set; }
    }
}