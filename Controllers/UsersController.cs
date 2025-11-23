using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using foodboxd_backend.Data;
using foodboxd_backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace foodboxd_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public UsersController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var user = await _appDbContext.Users.FirstOrDefaultAsync(u =>
                u.Email == request.Email);

            if (user == null)
            {
                return Unauthorized(new { message = "Email ou senha incorretos" });
            }

            if (!VerifyPasswordHash(request.Password, user.PasswordHash, user.PasswordSalt))
            {
                return Unauthorized(new { message = "Email ou senha incorretos" });
            }

            return Ok(new
            {
                userId = user.UserId,
                name = user.Name,
                email = user.Email
            });
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            if (await _appDbContext.Users.AnyAsync(u => u.Email == request.Email))
            {
                return BadRequest(new { message = "Este e-mail já está em uso." });
            }

            CreatePasswordHash(request.Password, out byte[] passwordHash, out byte[] passwordSalt);

            var newUser = new User
            {
                Name = request.Name,
                Email = request.Email,
                Birthdate = request.Birthdate,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                CreatedAt = DateTime.UtcNow
            };

            _appDbContext.Users.Add(newUser);
            await _appDbContext.SaveChangesAsync();

            return Ok(new
            {
                userId = newUser.UserId,
                name = newUser.Name,
                email = newUser.Email
            });
        }

[       HttpPut("{id}/profile")]
        public async Task<IActionResult> UpdateProfile(int id, [FromBody] UpdateProfileRequest request)
        {
            if (id != request.AuthUserId)
            {
                return Unauthorized(new { message = "Você não tem permissão para editar este perfil." });
            }

            var user = await _appDbContext.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound(new { message = "Usuário não encontrado." });
            }

            user.Name = request.Name;
            user.Biography = request.Biography;
            // TODO: Implementar lógica de upload para ProfilePhoto se desejar

            _appDbContext.Users.Update(user);
            await _appDbContext.SaveChangesAsync();

            return Ok(new
            {
                name = user.Name,
                biography = user.Biography
            });
        }

        [HttpGet("{id}/profile")]
        public async Task<IActionResult> GetUserProfile(int id)
        {
            var userProfile = await _appDbContext.Users
                .Where(u => u.UserId == id)
                .Include(u => u.Ratings)
                    .ThenInclude(r => r.Dish)
                .Include(u => u.Favorites)
                    .ThenInclude(f => f.Dish)
                .Select(u => new
                {
                    userId = u.UserId,
                    name = u.Name,
                    biography = u.Biography,
                    profilePhoto = u.ProfilePhoto != null ? Convert.ToBase64String(u.ProfilePhoto) : null,
                    memberSince = u.CreatedAt,

                    stats = new
                    {
                        dishesRated = u.Ratings.Select(r => r.DishId).Distinct().Count(),
                        reviewsCount = u.Ratings.Count(),
                        averageScore = u.Ratings.Any() ? u.Ratings.Average(r => r.Score) : 0,

                        followers = 342,
                        following = 156
                    },

                    ratedDishes = u.Ratings
                        .OrderByDescending(r => r.CreatedAt)
                        .Select(r => new
                        {
                            dishId = r.Dish.DishId,
                            dishName = r.Dish.Name,
                            dishPhoto = r.Dish.Photo,
                            userScore = r.Score
                        }).ToList(),

                    favoriteDishes = u.Favorites
                        .Select(f => new
                        {
                            dishId = f.Dish.DishId,
                            dishName = f.Dish.Name,
                            dishPhoto = f.Dish.Photo
                        }).ToList()

                })
                .FirstOrDefaultAsync();

            if (userProfile == null)
            {
                return NotFound(new { message = "Perfil de usuário não encontrado" });
            }

            return Ok(userProfile);
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
        }
    }

    public class LoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class RegisterRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateOnly Birthdate { get; set; }
    }

    public class UpdateProfileRequest
    {
        public int AuthUserId { get; set; }
        public string Name { get; set; }
        public string Biography { get; set; }
    }
}