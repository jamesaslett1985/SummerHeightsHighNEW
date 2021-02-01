using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Website.Models;

namespace Website.Controllers
{
    public class CheatSheetController : Controller
    {
        public IActionResult Index()
        {
            //you must new up an instance of the Model in the Controller, or the View won't know anything about the properties in the Model
            var CheatSheetModel = new CheatSheet();
            CheatSheetModel.Countries = new List<Country>()
            {            
                new Country("USA", "United States of America"),
                new Country("GB", "United Kingdom"),
                new Country("GRY", "Germany"),  
            };
            CheatSheetModel.Movies = new List<Movie>()
            {
        new Movie() { Id = 1, Title = "The Godfather" },
        new Movie() { Id = 2, Title = "Forrest Gump" },
        new Movie() { Id = 3, Title = "Fight Club" },
            };
            return View(CheatSheetModel);
        }
    }
}
