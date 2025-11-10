using foodboxd_backend.Models;
using foodboxd_backend.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace foodboxd_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecipeIngredientController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public RecipeIngredientController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;

            //TODO: fazer o controlete surfete
        }
    }
}