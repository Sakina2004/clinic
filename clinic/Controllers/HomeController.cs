using System.Diagnostics;
//using clinic.Models;
using Microsoft.AspNetCore.Mvc;

namespace clinic.Controllers
{
    public class HomeController : Controller
    {
      

        public IActionResult Index()
        {
            return View();
        }

 
    }
}
