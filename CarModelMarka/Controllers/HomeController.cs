using CarModelMarka.DataAccesLayer;
using CarModelMarka.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarModelMarka.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        { 
            var marka=_context.Markas;
            return View(marka);
        }

    }
}
