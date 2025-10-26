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
            var dish = await _appDbContext.Dishes.FindAsync(id);
            if (dish == null)
            {
                return NotFound(new { message = "Prato não encontrado" });
            }

            return Ok(new
            {
                dishId = dish.DishId,
                name = dish.Name,
                description = dish.Description,
                photo = dish.Photo
            });
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
            public byte[] Photo { get; set; }
        }

        public class UpdateDishRequest
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public byte[] Photo{ get; set; }
        }
    }    

}