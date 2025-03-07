using Microsoft.AspNetCore.Mvc;
using MinuteMeals.Core;

namespace MinuteMeals.Controllers
{
    public class RecipeController : Controller
    {
        public readonly RecipeDatabank database;
        public RecipeController(RecipeDatabank recipeDatabank)
        {
            database = recipeDatabank;
        }

        [HttpGet()]
        public IActionResult Index()
        {
            var recipes = database.recipes;
            return View(recipes);
        }
    }
}
