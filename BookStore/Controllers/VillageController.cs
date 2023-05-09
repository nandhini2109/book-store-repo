using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class VillageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
