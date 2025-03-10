using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace WebApplication30.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Welcome()
        {
            return View();
        }

        [Route("Page/Welcome/{name}")]
        public IActionResult Welcome(string name)
        {
            ViewData["Name"] = name; 
            return View();
        }

        [HttpPost]
        public IActionResult Edit (string message)
        {
            ViewData["Message"] = message;
            return View("EditResult");
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }
    }
}
