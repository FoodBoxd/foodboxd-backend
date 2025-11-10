using foodboxd_backend.Models;
using foodboxd_backend.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq; // Necessário para .Any(), .Average(), .Count()
using System; // Necessário para Task
using System.Collections.Generic; // Necessário para IEnumerable

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

        [HttpGet("search")]
        public async Task<IActionResult> SearchDishes([FromQuery] string q)
        {
            var searchTerm = q != null ? q.ToLower().Trim() : string.Empty;

            // 1. Inicia a consulta base incluindo o necessário para a busca
            var baseQuery = _appDbContext.Dishes
                .Include(d => d.Recipe)
                    .ThenInclude(r => r.RecipeIngredients)
                    .ThenInclude(ri => ri.Ingredient)
                .AsQueryable(); // Converte para IQueryable para adicionar filtros

            IQueryable<Dish> filteredQuery;

            // 2. Aplica o filtro de busca SE o searchTerm não for vazio
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                filteredQuery = baseQuery.Where(d =>
                    EF.Functions.Like(d.Name.ToLower(), $"%{searchTerm}%") ||
                    EF.Functions.Like(d.Description.ToLower(), $"%{searchTerm}%") ||
                    (d.Recipe != null && EF.Functions.Like(d.Recipe.Instructions.ToLower(), $"%{searchTerm}%")) ||
                    (d.Recipe != null && d.Recipe.RecipeIngredients.Any(ri =>
                        EF.Functions.Like(ri.Ingredient.Name.ToLower(), $"%{searchTerm}%")
                    ))
                );
            }
            else
            {
                // 3. Se a busca for vazia, usa a consulta base (todos os pratos)
                filteredQuery = baseQuery;
            }

            // 4. Executa a consulta (filtrada ou não) e projeta o resultado
            //    Incluindo os Ratings para os cálculos de média e contagem
            var results = await filteredQuery
                .Include(d => d.Ratings) // <-- INCLUI RATINGS PARA OS CÁLCULOS
                .Select(d => new
                {
                    id = d.DishId,
                    name = d.Name,
                    imageUrl = d.Photo, // Nome da prop que o frontend espera

                    // Cálculos de Média e Contagem
                    ratingCount = d.Ratings.Count(),
                    averageScore = d.Ratings.Any() ? d.Ratings.Average(r => r.Score) : 0.0
                })
                .ToListAsync();

            return Ok(results);
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
            public string Photo { get; set; }
        }
    }

}