using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Mamba_mvc.Controllers
{
    public class HomeController : Controller
    {
      
        public IActionResult Index()
        {
            return View();
        }


    }
}