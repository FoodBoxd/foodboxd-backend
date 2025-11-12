using System;
using System.Threading.Tasks;
using foodboxd_backend.Data;
using foodboxd_backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

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
                    name = user?.Name ?? "Usuário"
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
                // Curtir
                var newLike = new RatingLike { UserId = request.UserId, RatingId = request.RatingId };
                _appDbContext.RatingLikes.Add(newLike);
                await _appDbContext.SaveChangesAsync();
                var likeCount = await _appDbContext.RatingLikes.CountAsync(rl => rl.RatingId == request.RatingId);
                return Ok(new { liked = true, likeCount });
            }
            else
            {
                // Descurtir
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