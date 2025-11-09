using System;
using System.Threading.Tasks;
using foodboxd_backend.Data;
using foodboxd_backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace foodboxd_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RatingsController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public RatingsController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        // POST: api/ratings/create
        [HttpPost("create")]
        public async Task<IActionResult> CreateRating([FromBody] CreateRatingRequest request)
        {
            if (request.Score < 1 || request.Score > 5)
            {
                return BadRequest(new { message = "A nota (Score) deve ser entre 1 e 5." });
            }

            var newRating = new Rating
            {
                UserId = request.UserId,
                DishId = request.DishId,
                Score = request.Score,
                Comment = request.Comment
                // CreatedAt será definido automaticamente pelo banco (NOW())
            };

            _appDbContext.Ratings.Add(newRating);
            await _appDbContext.SaveChangesAsync();

            // Após salvar, buscamos os dados do usuário para retornar o objeto completo
            var user = await _appDbContext.Users.FindAsync(request.UserId);
            
            // Retornamos um objeto formatado da mesma maneira que a página de receita espera
            // Isso permite ao frontend adicionar o novo comentário à lista instantaneamente.
            return Ok(new
            {
                ratingId = newRating.RatingId,
                score = newRating.Score,
                comment = newRating.Comment,
                createdAt = newRating.CreatedAt,
                user = new
                {
                    name = user?.Name ?? "Usuário" // Retorna o nome do usuário ou "Usuário"
                }
            });
        }
    }

    // DTO para receber os dados do frontend
    public class CreateRatingRequest
    {
        public int UserId { get; set; }
        public int DishId { get; set; }
        public int Score { get; set; }
        public string Comment { get; set; }
    }
}