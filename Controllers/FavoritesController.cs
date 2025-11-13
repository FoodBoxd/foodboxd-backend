using foodboxd_backend.Models;
using foodboxd_backend.Data;
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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Favorite>>> GetFavorites()
        {
            if (_appDbContext.Favorites == null)
            {
                return NotFound("Tabela favorites não encontrada");
            }

            var favorites = await _appDbContext.Favorites.ToListAsync();
            return Ok(favorites);
        }

        [HttpGet("user/{userId}")]
        public async Task<ActionResult<IEnumerable<object>>> GetFavoritesByUser(int userId)
        {
            var favorites = await _appDbContext.Favorites
                .Where(f => f.UserId == userId)
                .Include(f => f.Dish)
                .ToListAsync();

            if (!favorites.Any())
            {
                return NotFound(new { message = "Nenhum favorito encontrado para este usuário" });
            }

            var result = favorites.Select(f => new
            {
                userId = f.UserId,
                dishId = f.DishId,
                dish = new
                {
                    dishId = f.Dish.DishId,
                    name = f.Dish.Name,
                    description = f.Dish.Description,
                    photo = f.Dish.Photo
                }
            });

            return Ok(result);
        }

        [HttpGet("dish/{dishId}")]
        public async Task<ActionResult<IEnumerable<Favorite>>> GetFavoritesByDish(int dishId)
        {
            var favorites = await _appDbContext.Favorites
                .Where(f => f.DishId == dishId)
                .Include(f => f.User)
                .ToListAsync();

            if (!favorites.Any())
            {
                return NotFound(new { message = "Nenhum usuário favoritou este prato" });
            }

            return Ok(favorites);
        }

        [HttpGet("check")]
        public async Task<ActionResult<object>> CheckFavorite([FromQuery] int userId, [FromQuery] int dishId)
        {
            var favorite = await _appDbContext.Favorites
                .FirstOrDefaultAsync(f => f.UserId == userId && f.DishId == dishId);

            return Ok(new
            {
                isFavorite = favorite != null
            });
        }

        [HttpPost]
        public async Task<IActionResult> CreateFavorite([FromBody] CreateFavoriteRequest request)
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

            // Verifica se o favorito já existe
            var existingFavorite = await _appDbContext.Favorites
                .FirstOrDefaultAsync(f => f.UserId == request.UserId && f.DishId == request.DishId);

            if (existingFavorite != null)
            {
                return BadRequest(new { message = "Este prato já está nos favoritos do usuário" });
            }

            var newFavorite = new Favorite
            {
                UserId = request.UserId,
                DishId = request.DishId
            };

            _appDbContext.Favorites.Add(newFavorite);
            await _appDbContext.SaveChangesAsync();

            return Ok(new
            {
                message = "Prato adicionado aos favoritos com sucesso",
                favorite = new
                {
                    userId = newFavorite.UserId,
                    dishId = newFavorite.DishId
                }
            });
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteFavorite([FromQuery] int userId, [FromQuery] int dishId)
        {
            var favorite = await _appDbContext.Favorites
                .FirstOrDefaultAsync(f => f.UserId == userId && f.DishId == dishId);

            if (favorite == null)
            {
                return NotFound(new { message = "Favorito não encontrado" });
            }

            _appDbContext.Favorites.Remove(favorite);
            await _appDbContext.SaveChangesAsync();

            return Ok(new { message = "Favorito removido com sucesso" });
        }

        public class CreateFavoriteRequest
        {
            public int UserId { get; set; }
            public int DishId { get; set; }
        }
    }
}