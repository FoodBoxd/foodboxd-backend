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

        // POST: api/users/login
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            // Busca o usuário pelo e-mail
            var user = await _appDbContext.Users.FirstOrDefaultAsync(u =>
                u.Email == request.Email);

            if (user == null)
            {
                return Unauthorized(new { message = "Email ou senha incorretos" });
            }

            // Verifica o hash da senha
            if (!VerifyPasswordHash(request.Password, user.PasswordHash, user.PasswordSalt))
            {
                return Unauthorized(new { message = "Email ou senha incorretos" });
            }

            // Sucesso: Retorna os dados do usuário para o frontend
            return Ok(new
            {
                userId = user.UserId,
                name = user.Name,
                email = user.Email
            });
        }

        // POST: api/users/register
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            // Verifica se o e-mail já existe
            if (await _appDbContext.Users.AnyAsync(u => u.Email == request.Email))
            {
                return BadRequest(new { message = "Este e-mail já está em uso." });
            }

            // Cria o Hash e o Salt da senha
            CreatePasswordHash(request.Password, out byte[] passwordHash, out byte[] passwordSalt);

            var newUser = new User
            {
                Name = request.Name,
                Email = request.Email,
                Birthdate = request.Birthdate,
                PasswordHash = passwordHash, // Salva o hash
                PasswordSalt = passwordSalt, // Salva o salt
                CreatedAt = DateTime.UtcNow
            };

            _appDbContext.Users.Add(newUser);
            await _appDbContext.SaveChangesAsync();

            // Sucesso: Retorna os dados do novo usuário para o frontend
            return Ok(new
            {
                userId = newUser.UserId,
                name = newUser.Name,
                email = newUser.Email
            });
        }

        // --- Outros Endpoints (ex: GetUserProfile) ---
        // (O restante do seu controller UsersController.cs permanece aqui...)
        [HttpGet("{id}/profile")]
        public async Task<IActionResult> GetUserProfile(int id)
        {
             // ... (código do GetUserProfile que você já tinha)
            var userProfile = await _appDbContext.Users
                .Where(u => u.UserId == id)
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
                        }).ToList()

                })
                .FirstOrDefaultAsync();

            if (userProfile == null)
            {
                return NotFound(new { message = "Perfil de usuário não encontrado" });
            }

            return Ok(userProfile);
        }

        // --- Métodos Auxiliares de Hashing ---

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

    // DTOs (Data Transfer Objects)
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
}