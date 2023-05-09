using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Bmw()
        {
            return View();
        }
    }
}
