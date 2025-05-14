using clinic.DataAccesLayer;
using Microsoft.AspNetCore.Mvc;

namespace clinic.Areas.Admin.Controllers
{
    public class ProductController(AppDbContext) : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
