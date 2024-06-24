using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ProducersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
