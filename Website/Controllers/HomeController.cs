using Code;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Website.Models;

namespace Website.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            //get characters from Dictionary and store as List<SelectListItem>
            var selectableCharacters = SummerHeightsHighService.Characters
                    .Select(kvp => new SelectListItem(kvp.Value.Name, kvp.Key))
                    .ToList();

            //new up Characters Model, as this ViewDataDictionary instance requires a Model item of type 'Website.Models.Characters'
            var characterListModel = new Characters();

            //sets our selectableCharacters variable to SelectableCharacters in Model
            characterListModel.SelectableCharacters = selectableCharacters;

            return View(characterListModel);
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
