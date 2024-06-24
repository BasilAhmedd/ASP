using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{

    public class ActorsController : Controller
    {
        private readonly AppDbContext _context;

        public ActorsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var actors = _context.actors.ToList();
            return View(actors);
        }  
        public IActionResult ActorDetails(int id)
        {
            var actor = _context.actors.FirstOrDefault(a=>a.ActorID == id);
            if(actor == null)
            {
                return View("Not Found");
            }
            return View(actor);
        }

        [HttpGet]
        public IActionResult ActorEdit(int id)
        {
            var actor = _context.actors.FirstOrDefault(a=>a.ActorID == id);
            if(actor == null)
            {
                return View("Not Found");
            }
            return View(actor);
        }

        [HttpPost]
        public IActionResult ActorEdit(actor actor)
        {
            if (ModelState.IsValid)
            {
                _context.actors.Update(actor);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
