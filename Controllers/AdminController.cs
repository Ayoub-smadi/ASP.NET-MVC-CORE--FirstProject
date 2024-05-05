using FinalMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalMVC.Controllers
{
    public class AdminController : Controller
    {
        private readonly ModelContext _context;

        public AdminController(ModelContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {


            
            return View();
        }
    }
}
