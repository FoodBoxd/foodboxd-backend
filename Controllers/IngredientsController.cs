using foodboxd_backend.Models;
using foodboxd_backend.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace foodboxd_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IngredientsController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public IngredientsController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ingredient>>> GetIngredients()
        {
            if (_appDbContext.Ingredients == null)
            {
                return NotFound("Tabela de ingredientes não encontrada.");
            }
            return await _appDbContext.Ingredients.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Ingredient>> GetIngredient(int id)
        {
            if (_appDbContext.Ingredients == null)
            {
                return NotFound("Tabela de ingredientes não encontrada.");
            }
            var ingredient = await _appDbContext.Ingredients.FindAsync(id);

            if (ingredient == null)
            {
                return NotFound("Ingrediente não encontrado.");
            }

            return ingredient;
        }

        [HttpPost]
        public async Task<ActionResult<Ingredient>> CreateIngredient([FromBody] IngredientRequest request)
        {
            if (_appDbContext.Ingredients == null)
            {
                return Problem("A entidade 'AppDbContext.Ingredients' é nula.");
            }

            var newIngredient = new Ingredient
            {
                Name = request.Name
            };

            _appDbContext.Ingredients.Add(newIngredient);
            await _appDbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetIngredient), new { id = newIngredient.IngredientId }, newIngredient);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateIngredient(int id, [FromBody] IngredientRequest request)
        {
            var ingredient = await _appDbContext.Ingredients.FindAsync(id);

            if (ingredient == null)
            {
                return NotFound(new { message = "Ingrediente não encontrado." });
            }

            if (!string.IsNullOrWhiteSpace(request.Name))
            {
                ingredient.Name = request.Name;
            }

            _appDbContext.Entry(ingredient).State = EntityState.Modified;

            try
            {
                await _appDbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_appDbContext.Ingredients.Any(e => e.IngredientId == id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok(new { message = "Ingrediente atualizado com sucesso" });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIngredient(int id)
        {
            if (_appDbContext.Ingredients == null)
            {
                return NotFound("Tabela de ingredientes não encontrada.");
            }
            var ingredient = await _appDbContext.Ingredients.FindAsync(id);
            if (ingredient == null)
            {
                return NotFound("Ingrediente não encontrado.");
            }

            _appDbContext.Ingredients.Remove(ingredient);
            await _appDbContext.SaveChangesAsync();

            return Ok(new { message = "Ingrediente deletado com sucesso." });
        }

        public class IngredientRequest
        {
            public string Name { get; set; }
        }
    }
}