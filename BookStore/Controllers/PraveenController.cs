using BookStore.Data;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class PraveenController : Controller
    {
        private ApplicationDbContext _db;

        public PraveenController(ApplicationDbContext db)
        {
            _db = db;
        }
            public IActionResult Index()
        {
            IEnumerable<MyPraveen> obj = _db.Praveen;
            return View(obj);
        }
    }
}
