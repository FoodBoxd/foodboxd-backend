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

                        ingredients = tb.Recipe.RecipeIngredients.Select(ri => new
                        {
                            ingredientId = ri.Ingredient.IngredientId,
                            name = ri.Ingredient.Name,
                            quantity = ri.Quantity,
                            measurementUnit = ri.MeasurementUnit
                        }).ToList() // Lista de ingredientes para esta receita
                    },

                    // 4. As Avaliações (Relacionamento 1:N)
                    ratings = tb.Ratings.Select(r => new
                    {
                        ratingId = r.RatingId,
                        score = r.Score,
                        comment = r.Comment, // O campo que você adicionou
                        createdAt = r.CreatedAt,

                        // 5. O Usuário que avaliou (N:1, a partir da Avaliação)
                        user = (r.User == null) ? null : new
                        {
                            userId = r.User.UserId,
                            name = r.User.Name,
                            profilePhoto = r.User.ProfilePhoto
                        }
                    }).ToList(), // Lista de avaliações para este prato

                    // 6. Contagem de Favoritos (Cálculo 1:N)
                    // EF Core traduz isso para um SQL COUNT() eficiente.
                    favoritesCount = tb.Favorites.Count()
                })
                .FirstOrDefaultAsync(); // Encontra o primeiro (e único) prato com esse ID

            // Se o Select() não encontrar nada, dishDetails será nulo
            if (dishDetails == null)
            {
                return NotFound(new { message = "Prato não encontrado" });
            }

            // Retorna o objeto complexo que acabamos de montar
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