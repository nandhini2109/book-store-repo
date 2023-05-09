using BookStore.Data;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class VotersController : Controller
    {
        private readonly ApplicationDbContext _db;

        public VotersController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Voters> objCategoryList = _db.India;
            return View(objCategoryList);
        
        }

    }
}
