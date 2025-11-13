using foodboxd_backend.Models;
using foodboxd_backend.Data;
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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rating>>> GetRatings()
        {
            if (_appDbContext.Ratings == null)
            {
                return NotFound("Tabela ratings não encontrada");
            }

            var ratings = await _appDbContext.Ratings.ToListAsync();
            return Ok(ratings);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRating(int id)
        {
            var rating = await _appDbContext.Ratings.FindAsync(id);
            if (rating == null)
            {
                return NotFound(new { message = "Avaliação não encontrada" });
            }

            return Ok(new
            {
                ratingId = rating.RatingId,
                score = rating.Score,
                createdAt = rating.CreatedAt,
                userId = rating.UserId,
                dishId = rating.DishId
            });
        }

        [HttpGet("user/{userId}")]
        public async Task<ActionResult<IEnumerable<Rating>>> GetRatingsByUser(int userId)
        {
            var ratings = await _appDbContext.Ratings
                .Where(r => r.UserId == userId)
                .ToListAsync();

            if (!ratings.Any())
            {
                return NotFound(new { message = "Nenhuma avaliação encontrada para este usuário" });
            }

            return Ok(ratings);
        }

        [HttpGet("dish/{dishId}")]
        public async Task<ActionResult<IEnumerable<Rating>>> GetRatingsByDish(int dishId)
        {
            var ratings = await _appDbContext.Ratings
                .Where(r => r.DishId == dishId)
                .ToListAsync();

            if (!ratings.Any())
            {
                return NotFound(new { message = "Nenhuma avaliação encontrada para este prato" });
            }

            return Ok(ratings);
        }

        [HttpGet("dish/{dishId}/average")]
        public async Task<ActionResult<object>> GetAverageRating(int dishId)
        {
            var ratings = await _appDbContext.Ratings
                .Where(r => r.DishId == dishId)
                .ToListAsync();

            if (!ratings.Any())
            {
                return NotFound(new { message = "Nenhuma avaliação encontrada para este prato" });
            }

            var average = ratings.Average(r => r.Score);
            var count = ratings.Count;

            return Ok(new
            {
                dishId = dishId,
                averageScore = average,
                totalRatings = count
            });
        }

        [HttpPost]
        public async Task<IActionResult> CreateRating([FromBody] CreateRatingRequest request)
        {
            // Verifica se o usuário existe
            var userExists = await _appDbContext.Users.AnyAsync(u => u.UserId == request.UserId);
            if (!userExists)
            {
                return NotFound(new { message = "Usuário não encontrado" });
            }

            // Verifica se o prato existe
            var dishExists = await _appDbContext.Dishes.AnyAsync(d => d.DishId == request.DishId);
            if (!dishExists)
            {
                return NotFound(new { message = "Prato não encontrado" });
            }

            // Verifica se o usuário já avaliou este prato
            var existingRating = await _appDbContext.Ratings
                .FirstOrDefaultAsync(r => r.UserId == request.UserId && r.DishId == request.DishId);

            if (existingRating != null)
            {
                return BadRequest(new { message = "Usuário já avaliou este prato" });
            }

            var newRating = new Rating
            {
                Score = request.Score,
                CreatedAt = DateTime.UtcNow,
                UserId = request.UserId,
                DishId = request.DishId
            };

            _appDbContext.Ratings.Add(newRating);
            await _appDbContext.SaveChangesAsync();

            return Ok(new
            {
                message = "Avaliação criada com sucesso",
                rating = new
                {
                    ratingId = newRating.RatingId,
                    score = newRating.Score,
                    createdAt = newRating.CreatedAt,
                    userId = newRating.UserId,
                    dishId = newRating.DishId
                }
            });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRating(int id, [FromBody] UpdateRatingRequest request)
        {
            var rating = await _appDbContext.Ratings.FindAsync(id);

            if (rating == null)
            {
                return NotFound(new { message = "Avaliação não encontrada" });
            }

            if (request.Score.HasValue)
                rating.Score = request.Score.Value;

            _appDbContext.Ratings.Update(rating);
            await _appDbContext.SaveChangesAsync();

            return Ok(new { message = "Avaliação atualizada com sucesso" });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRating(int id)
        {
            var rating = await _appDbContext.Ratings.FindAsync(id);
            if (rating == null)
            {
                return NotFound(new { message = "Avaliação não encontrada" });
            }

            _appDbContext.Ratings.Remove(rating);
            await _appDbContext.SaveChangesAsync();

            return Ok(new { message = "Avaliação deletada com sucesso" });
        }

        public class CreateRatingRequest
        {
            public int Score { get; set; }
            public int UserId { get; set; }
            public int DishId { get; set; }
        }

        public class UpdateRatingRequest
        {
            public int? Score { get; set; }
        }
    }
}