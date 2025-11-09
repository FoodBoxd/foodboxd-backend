using foodboxd_backend.Models;
using foodboxd_backend.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace foodboxd_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DishesController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public DishesController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dish>>> GetDishes()
        {
            if (_appDbContext.Dishes == null)
            {
                return NotFound("Tabela dishes não encontrada");
            }

            var dishes = await _appDbContext.Dishes.ToListAsync();
            return Ok(dishes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDish(int id)
        {
            var dishDetails = await _appDbContext.Dishes
                .AsNoTracking()
                .Where(tb => tb.DishId == id)
                .Select(tb => new
                {
                    dishId = tb.DishId,
                    name = tb.Name,
                    description = tb.Description,
                    photo = tb.Photo,

                    recipe = (tb.Recipe == null) ? null : new
                    {
                        recipeId = tb.Recipe.RecipeId,
                        instructions = tb.Recipe.Instructions,

                        ingredients = tb.Recipe.RecipeIngredients.Select(tb => new
                        {
                            ingredientId = tb.Ingredient.IngredientId,
                            name = tb.Ingredient.Name,
                            quantity = tb.Quantity,
                            measurementUnit = tb.MeasurementUnit
                        }).ToList()
                    },

                    ratings = tb.Ratings.Select(tb => new
                    {
                        ratingId = tb.RatingId,
                        score = tb.Score,
                        comment = tb.Comment,
                        createdAt = tb.CreatedAt,

                        user = (tb.User == null) ? null : new
                        {
                            userId = tb.User.UserId,
                            name = tb.User.Name,
                            profilePhoto = tb.User.ProfilePhoto
                        }
                    }).ToList(),

                    favoritesCount = tb.Favorites.Count()
                })
                .FirstOrDefaultAsync();

            if (dishDetails == null)
            {
                return NotFound(new { message = "Prato não encontrado" });
            }

            return Ok(dishDetails);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDish([FromBody] CreateDishRequest request)
        {
            var newDish = new Dish
            {
                Name = request.Name,
                Description = request.Description,
                Photo = request.Photo
            };

            _appDbContext.Dishes.Add(newDish);
            await _appDbContext.SaveChangesAsync();

            return Ok(new
            {
                message = "Prato criado com sucesso",
                dish = new
                {
                    dishId = newDish.DishId,
                    name = newDish.Name,
                    description = newDish.Description

                }
            });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDish(int id, [FromBody] UpdateDishRequest request)
        {
            var dish = await _appDbContext.Dishes.FindAsync(id);

            if (dish == null)
            {
                return NotFound(new { message = "Prato não encontrada" });
            }

            if (!string.IsNullOrWhiteSpace(request.Name))
                dish.Name = request.Name;

            if (!string.IsNullOrWhiteSpace(request.Description))
                dish.Description = request.Description;

            if (request.Photo != null)
                dish.Photo = request.Photo;

            _appDbContext.Dishes.Update(dish);
            await _appDbContext.SaveChangesAsync();

            return Ok(new { message = "prato atualizado com sucesso" });

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDish(int id)
        {
            var dish = await _appDbContext.Dishes.FindAsync(id);
            if (dish == null)
            {
                return NotFound(new { message = "Prato não encontrado" });
            }

            _appDbContext.Dishes.Remove(dish);
            await _appDbContext.SaveChangesAsync();

            return Ok(new { message = "Prato deletado com sucesso" });

        }

        public class CreateDishRequest
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string Photo { get; set; }
        }

        public class UpdateDishRequest
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string Photo{ get; set; }
        }
    }

}