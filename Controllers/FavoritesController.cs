using System.Threading.Tasks;
using foodboxd_backend.Data;
using foodboxd_backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace foodboxd_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FavoritesController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public FavoritesController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpPost("toggle")]
        public async Task<IActionResult> ToggleFavorite([FromBody] ToggleFavoriteRequest request)
        {
            var existingFavorite = await _appDbContext.Favorites
                .FirstOrDefaultAsync(f => f.UserId == request.UserId && f.DishId == request.DishId);

            if (existingFavorite == null)
            {
                var newFavorite = new Favorite { UserId = request.UserId, DishId = request.DishId };
                _appDbContext.Favorites.Add(newFavorite);
                await _appDbContext.SaveChangesAsync();

                var count = await _appDbContext.Favorites.CountAsync(f => f.DishId == request.DishId);
                return Ok(new { favorited = true, favoritesCount = count });
            }
            else
            {
                _appDbContext.Favorites.Remove(existingFavorite);
                await _appDbContext.SaveChangesAsync();

                var count = await _appDbContext.Favorites.CountAsync(f => f.DishId == request.DishId);
                return Ok(new { favorited = false, favoritesCount = count });
            }
        }
    }

    public class ToggleFavoriteRequest
    {
        public int UserId { get; set; }
        public int DishId { get; set; }
    }
}