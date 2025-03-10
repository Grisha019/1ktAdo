using Microsoft.AspNetCore.Mvc;

namespace WebApplication30.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Welcome()
        {
            return View();
        }
    }
}
