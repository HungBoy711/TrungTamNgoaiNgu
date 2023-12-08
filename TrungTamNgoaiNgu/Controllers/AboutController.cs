using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TrungTamNgoaiNgu.Models;

namespace TrungTamNgoaiNgu.Controllers
{
    public class AboutController : Controller
    {
        private readonly DataContext _context;

        public AboutController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
