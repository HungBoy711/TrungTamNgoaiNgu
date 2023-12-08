using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TrungTamNgoaiNgu.Models;

namespace TrungTamNgoaiNgu.Controllers
{
    public class CourseController : Controller
    {
        private readonly DataContext _context;

        public CourseController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
