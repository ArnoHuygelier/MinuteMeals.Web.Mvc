using MinuteMeals.Models;

namespace MinuteMeals.Core
{
    public class RecipeDatabank
    {
        public IList<Recipe> recipes { get; set; } = new List<Recipe>();

        public void seed()
        {
            recipes = new List<Recipe>
            {
                new Recipe
                {
                    Id = 1,
                    Name = "Pasta Carbonara",
                    Ingredients = "Spaghetti, eieren, spek, Parmezaanse kaas, peper, zout",
                    Steps = "Kook de spaghetti. Bak het spek. Meng eieren met kaas en voeg toe aan de spaghetti met spek.",
                    CookingTimeInMinutes = 20
                },
                new Recipe
                {
                    Id = 2,
                    Name = "Tomatensoep",
                    Ingredients = "Tomaten, ui, knoflook, bouillon, basilicum",
                    Steps = "Fruit ui en knoflook. Voeg tomaten en bouillon toe. Laat sudderen en pureer.",
                    CookingTimeInMinutes = 30
                },
                new Recipe
                {
                    Id = 3,
                    Name = "Omelet",
                    Ingredients = "Eieren, melk, kaas, ham, zout, peper",
                    Steps = "Klop de eieren met melk. Bak in een pan en voeg kaas en ham toe.",
                    CookingTimeInMinutes = 10
                },
                new Recipe
                {
                    Id = 4,
                    Name = "Caesar Salad",
                    Ingredients = "Kipfilet, Romaine sla, croutons, Parmezaanse kaas, Caesar dressing",
                    Steps = "Grill de kip. Meng met sla, croutons, kaas en dressing.",
                    CookingTimeInMinutes = 15
                },
                new Recipe
                {
                    Id = 5,
                    Name = "Chili con Carne",
                    Ingredients = "Gehakt, bonen, tomaten, ui, knoflook, chilipoeder",
                    Steps = "Bak gehakt met ui en knoflook. Voeg tomaten en bonen toe en laat sudderen.",
                    CookingTimeInMinutes = 45
                },
                new Recipe
                {
                    Id = 6,
                    Name = "Pannenkoeken",
                    Ingredients = "Bloem, melk, eieren, boter, suiker",
                    Steps = "Mix bloem, melk en eieren. Bak in boter en serveer met suiker.",
                    CookingTimeInMinutes = 25
                },
                new Recipe
                {
                    Id = 7,
                    Name = "Lasagne",
                    Ingredients = "Lasagnebladen, gehakt, tomatensaus, bechamelsaus, kaas",
                    Steps = "Bak gehakt en meng met tomatensaus. Bouw lagen met lasagnebladen en saus. Bak in de oven.",
                    CookingTimeInMinutes = 50
                },
                new Recipe
                {
                    Id = 8,
                    Name = "Biefstuk met kruidenboter",
                    Ingredients = "Biefstuk, boter, knoflook, kruiden",
                    Steps = "Bak de biefstuk naar wens. Smelt kruidenboter eroverheen.",
                    CookingTimeInMinutes = 15
                },
                new Recipe
                {
                    Id = 9,
                    Name = "Curry met rijst",
                    Ingredients = "Kip, currypasta, kokosmelk, groente, rijst",
                    Steps = "Bak kip en groente. Voeg currypasta en kokosmelk toe. Serveer met rijst.",
                    CookingTimeInMinutes = 35
                },
                new Recipe
                {
                    Id = 10,
                    Name = "Tiramisu",
                    Ingredients = "Mascarpone, koffie, lange vingers, cacao, suiker, eieren",
                    Steps = "Klop mascarpone met suiker en eieren. Doop lange vingers in koffie en bouw lagen. Bestrooi met cacao.",
                    CookingTimeInMinutes = 0 // Geen kooktijd, maar moet opstijven in de koelkast
                }
            };
        }
    }
}
