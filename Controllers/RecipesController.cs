using foodboxd_backend.Models;
using foodboxd_backend.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace foodboxd_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecipesController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public RecipesController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Recipe>>> GetRecipes()
        {
            if (_appDbContext.Recipes == null)
            {
                return NotFound("Tabela Recipes não encontrada");
            }

            var recipes = await _appDbContext.Recipes.ToListAsync();
            return Ok(recipes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Recipe>> GetRecipe(int id)
        {
            if (_appDbContext.Recipes == null)
            {
                return NotFound("Tabela de receitas não encontrada.");
            }
            var recipe = await _appDbContext.Recipes.FindAsync(id);

            if (recipe == null)
            {
                return NotFound("Receita não encontrado.");
            }

            return recipe;
        }

        [HttpPost]
        public async Task<ActionResult<Recipe>> CreateRecipe([FromBody] CreateRecipeRequest request)
        {
            if (_appDbContext.Recipes == null)
            {
                return Problem("A entidade 'AppDbContext.Recipes' é nula.");
            }

            // Verifica se o DishId fornecido existe
            var dishExists = await _appDbContext.Dishes.AnyAsync(d => d.DishId == request.DishId);
            if (!dishExists)
            {
                return BadRequest(new { message = "O prato (Dish) com o ID fornecido não existe." });
            }

            var newRecipe = new Recipe
            {
                Instructions = request.Instructions,
                DishId = request.DishId
            };

            _appDbContext.Recipes.Add(newRecipe);
            await _appDbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetRecipe), new { id = newRecipe.RecipeId }, newRecipe);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRecipe(int id, [FromBody] UpdateRecipeRequest request)
        {
            var recipe = await _appDbContext.Recipes.FindAsync(id);

            if (recipe == null)
            {
                return NotFound(new { message = "Receita nao encontrada" });
            }

            if (!string.IsNullOrWhiteSpace(request.Instructions))
            {
                recipe.Instructions = request.Instructions;
            }

            if (request.DishId.HasValue)
            {
                var dishExists = await _appDbContext.Dishes.AnyAsync(d => d.DishId == request.DishId.Value);
                if (!dishExists)
                {
                    return BadRequest(new { message = "O prato (Dish) com o novo ID fornecido não existe." });
                }
                recipe.DishId = request.DishId.Value;
            }

            _appDbContext.Entry(recipe).State = EntityState.Modified;

            try
            {
                await _appDbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_appDbContext.Recipes.Any(e => e.RecipeId == id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRecipe(int id)
        {
            if (_appDbContext.Recipes == null)
            {
                return NotFound("Tabela de receitas não encontrada.");
            }
            var recipe = await _appDbContext.Recipes.FindAsync(id);
            if (recipe == null)
            {
                return NotFound("Receita não encontrada.");
            }

            _appDbContext.Recipes.Remove(recipe);
            await _appDbContext.SaveChangesAsync();

            return Ok(new { message = "Receita deletada com sucesso." });
        }


        public class CreateRecipeRequest
        {
            public string Instructions { get; set; }
            public int DishId { get; set; }
        }

        public class UpdateRecipeRequest
        {
            public string Instructions { get; set; }
            public int? DishId { get; set; }
        }
    }
}