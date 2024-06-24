using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class CinemaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
