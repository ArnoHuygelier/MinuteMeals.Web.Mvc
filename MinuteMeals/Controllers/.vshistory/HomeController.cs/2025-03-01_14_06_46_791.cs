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

    public IActionResult RecipePage(int id)
    {
        var recipes = database.recipes;
        return View(recipes);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
