using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Website.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Http(int statusCode)
        {
            // Log error, e.g. to a database. You can use the HttpContext.Request object to access important information like the requested URL 

            if (statusCode == 404)
            {
                return View("Error404"); //return 404 specific View
            }
            return View("ErrorGeneric"); //return generic View
        }
    }
}
