using Classtask1_180325.DATA;
using Microsoft.AspNetCore.Mvc;

namespace Classtask1_180325.Controllers
{
    public class HomeController(AppDbContext appDbContext) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
