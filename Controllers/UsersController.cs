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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            // Verifica se o DbSet (a tabela) existe no DbContext
            if (_appDbContext.Users == null)
            {
                // Retorna 404 se o DbSet não estiver configurado corretamente
                return NotFound("Tabela de usuários (Users DbSet) não encontrada no contexto.");
            }

            // Busca todos os registros da tabela 'Users' de forma assíncrona
            var users = await _appDbContext.Users.ToListAsync();

            // Retorna o status 200 OK junto com a lista de usuários.
            return Ok(users);
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(User user)
        {
            _appDbContext.Users.Add(user);
            await _appDbContext.SaveChangesAsync();

            return Ok(user);
        }
    }
}