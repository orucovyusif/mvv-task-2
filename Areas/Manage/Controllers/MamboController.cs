using Microsoft.AspNetCore.Mvc;

namespace Mamba_mvc.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class MamboController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
