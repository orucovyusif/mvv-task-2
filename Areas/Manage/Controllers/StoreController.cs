using Mamba_mvc.DATA;
using Mamba_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mamba_mvc.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class StoreController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public StoreController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            return View(_context.Stores.ToList());
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Store store)
        {
            if (!ModelState.IsValid)
            {
                return View(store);
            }

            string path = _webHostEnvironment.WebRootPath + @"\Upload\Store\";
            //string fileName =
            return Ok();

        }
    }
}
