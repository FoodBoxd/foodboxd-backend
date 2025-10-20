using System;
using System.Collections.Generic;
using System.Linq;
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

        // GET: api/users - Busca todos os usuários
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            if (_appDbContext.Users == null)
            {
                return NotFound("Tabela de usuários (Users DbSet) não encontrada no contexto.");
            }

            var users = await _appDbContext.Users.ToListAsync();
            return Ok(users);
        }

        // POST: api/users - Cria um novo usuário
        [HttpPost]
        public async Task<IActionResult> AddUser(User user)
        {
            _appDbContext.Users.Add(user);
            await _appDbContext.SaveChangesAsync();
            return Ok(user);
        }

        // POST: api/users/login - Faz login
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var user = await _appDbContext.Users.FirstOrDefaultAsync(u => 
                u.Email == request.Email && u.Password == request.Password);

            if (user == null)
            {
                return Unauthorized(new { message = "Email ou senha incorretos" });
            }

            return Ok(new
            {
                message = "Login realizado com sucesso",
                user = new
                {
                    userId = user.UserId,
                    name = user.Name,
                    email = user.Email
                }
            });
        }

        // POST: api/users/register - Cadastra um novo usuário
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            var existingUser = await _appDbContext.Users.FirstOrDefaultAsync(u => u.Email == request.Email);
            if (existingUser != null)
            {
                return BadRequest(new { message = "Email já cadastrado" });
            }

            var newUser = new User
            {
                Name = request.Name,
                Email = request.Email,
                Password = request.Password,
                CreatedAt = DateTime.UtcNow
            };

            _appDbContext.Users.Add(newUser);
            await _appDbContext.SaveChangesAsync();

            return Ok(new
            {
                message = "Usuário cadastrado com sucesso",
                user = new
                {
                    userId = newUser.UserId,
                    name = newUser.Name,
                    email = newUser.Email
                }
            });
        }

        // GET: api/users/{id} - Busca um usuário específico
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _appDbContext.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound(new { message = "Usuário não encontrado" });
            }

            return Ok(new
            {
                userId = user.UserId,
                name = user.Name,
                email = user.Email,
                createdAt = user.CreatedAt
            });
        }
    }

    // DTOs - Classes para receber dados do frontend
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
    }
}