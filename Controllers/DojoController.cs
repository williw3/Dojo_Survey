using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace dojo_survey.Controllers
{
    public class DojoController : Controller
    {
        [HttpGet]  
        [Route("index")]  //Can also put params in routes: Route("template/{Name}")
        public IActionResult index()
        {
            return View("index");
        }

        [HttpPost]  
        [Route("display")]  
        public IActionResult display(string firstname, string lastname, string email,
                                    string location, string language, string comment)
        {
            ViewBag.first = firstname;
            ViewBag.last = lastname;
            ViewBag.email = email;
            ViewBag.loc = location;
            ViewBag.lang = language;
            ViewBag.comm = comment;
            return View("display");
        }
    }
}
