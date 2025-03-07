using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MinuteMeals.Core;
using MinuteMeals.Models;

namespace MinuteMeals.Controllers;

public class HomeController : Controller
{
    public readonly RecipeDatabank database;
    public HomeController(RecipeDatabank recipeDatabank)
    {
        database = recipeDatabank;
    }

    [HttpGet()]
    public IActionResult Index()
    {
        var recipes = database.recipes;
        return View(recipes);
    }

    [HttpGet()]
    [Route("recipe/{id}")]
    public IActionResult Recipe(int id)
    {
        Recipe? recipe = database.recipes.FirstOrDefault(x => x.Id == id);
        return View(recipe);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
