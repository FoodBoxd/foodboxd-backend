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
                        name = r.User.Name,
                        profilePhoto = r.User.ProfilePhoto
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

            var newRating = new Rating
            {
                UserId = request.UserId,
                DishId = request.DishId,
                Score = request.Score,
                Comment = request.Comment,
                CreatedAt = DateTime.UtcNow
            };

            _appDbContext.Ratings.Add(newRating);
            await _appDbContext.SaveChangesAsync();

            var user = await _appDbContext.Users.FindAsync(request.UserId);

            return Ok(new
            {
                ratingId = newRating.RatingId,
                score = newRating.Score,
                comment = newRating.Comment,
                createdAt = newRating.CreatedAt,
                user = new
                {
                    userId = user.UserId,
                    name = user?.Name ?? "Usuário",
                    profilePhoto = user?.ProfilePhoto
                },
                likeCount = 0,
                isLikedByCurrentUser = false
            });
        }

        [HttpPost("toggle-like")]
        public async Task<IActionResult> ToggleLike([FromBody] LikeRequest request)
        {
            var existingLike = await _appDbContext.RatingLikes
                .FirstOrDefaultAsync(rl => rl.UserId == request.UserId && rl.RatingId == request.RatingId);

            if (existingLike == null)
            {
                var newLike = new RatingLike { UserId = request.UserId, RatingId = request.RatingId };
                _appDbContext.RatingLikes.Add(newLike);
                await _appDbContext.SaveChangesAsync();
                var likeCount = await _appDbContext.RatingLikes.CountAsync(rl => rl.RatingId == request.RatingId);
                return Ok(new { liked = true, likeCount });
            }
            else
            {
                _appDbContext.RatingLikes.Remove(existingLike);
                await _appDbContext.SaveChangesAsync();
                var likeCount = await _appDbContext.RatingLikes.CountAsync(rl => rl.RatingId == request.RatingId);
                return Ok(new { liked = false, likeCount });
            }
        }
    }

    public class CreateRatingRequest
    {
        public int UserId { get; set; }
        public int DishId { get; set; }
        public int Score { get; set; }
        public string Comment { get; set; }
    }

    public class LikeRequest
    {
        public int UserId { get; set; }
        public int RatingId { get; set; }
    }
}