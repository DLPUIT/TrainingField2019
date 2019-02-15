using Microsoft.AspNetCore.Mvc;

namespace EventsCase.Controllers
{
   
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}