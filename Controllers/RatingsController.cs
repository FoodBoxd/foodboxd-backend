using System;
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
    public class RatingsController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public RatingsController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet("feed")]
        public async Task<IActionResult> GetFeed([FromQuery] int? userId, [FromQuery] int page = 1, [FromQuery] int pageSize = 10)
        {
            var query = _appDbContext.Ratings.AsQueryable();

            if (userId.HasValue)
            {
                query = query
                    .Where(r => r.UserId == userId.Value)
                    .OrderByDescending(r => r.CreatedAt);
            }
            else
            {
                query = query
                    .Include(r => r.Dish.Favorites) 
                    .Include(r => r.Dish.Ratings) 
                    .OrderByDescending(r => r.Dish.Favorites.Count())
                    .ThenByDescending(r => r.Dish.Ratings.Count())
                    .ThenByDescending(r => r.CreatedAt);
            }

            var totalItems = await query.CountAsync();
            var totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);

            var ratings = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(r => new
                {
                    ratingId = r.RatingId,
                    score = r.Score,
                    comment = r.Comment,
                    createdAt = r.CreatedAt,
                    user = new
                    {
                        userId = r.User.UserId,
                        name = r.User.Name
                    },
                    dish = new
                    {
                        dishId = r.Dish.DishId,
                        name = r.Dish.Name,
                        photo = r.Dish.Photo
                    }
                })
                .ToListAsync();

            return Ok(new
            {
                items = ratings,
                currentPage = page,
                totalPages = totalPages,
                hasMorePages = page < totalPages
            });
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateRating([FromBody] CreateRatingRequest request)
        {
            if (request.Score < 1 || request.Score > 5)
            {
                return BadRequest(new { message = "A nota (Score) deve ser entre 1 e 5." });
            }

            var existingRating = await _appDbContext.Ratings
                .FirstOrDefaultAsync(r => r.UserId == request.UserId && r.DishId == request.DishId);

            if (existingRating != null)
            {
                existingRating.Score = request.Score;
                existingRating.Comment = request.Comment;
                existingRating.CreatedAt = DateTime.UtcNow;
                _appDbContext.Ratings.Update(existingRating);
            }
            else
            {
                existingRating = new Rating
                {
                    UserId = request.UserId,
                    DishId = request.DishId,
                    Score = request.Score,
                    Comment = request.Comment
                };
                _appDbContext.Ratings.Add(existingRating);
            }
            
            await _appDbContext.SaveChangesAsync();

            var user = await _appDbContext.Users.FindAsync(request.UserId);
            
            return Ok(new
            {
                ratingId = existingRating.RatingId,
                score = existingRating.Score,
                comment = existingRating.Comment,
                createdAt = existingRating.CreatedAt,
                user = new
                {
                    userId = user.UserId,
                    name = user?.Name ?? "Usuário"
                }
            });
        }
    }

    public class CreateRatingRequest
    {
        public int UserId { get; set; }
        public int DishId { get; set; }
        public int Score { get; set; }
        public string Comment { get; set; }
    }
}