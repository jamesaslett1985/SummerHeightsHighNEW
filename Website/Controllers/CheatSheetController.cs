using Microsoft.AspNetCore.Mvc;
using Website.Models;

namespace Website.Controllers
{
    public class CheatSheetController : Controller
    {
        public IActionResult Index()
        {
            //you must new up an instance of the Model in the Controller, or the View won't know anything about the properties in the Model
            var CheatSheetModel = new CheatSheet();

            return View(CheatSheetModel);
        }
    }
}
