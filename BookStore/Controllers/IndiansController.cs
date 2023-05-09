using BookStore.Data;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class IndiansController : Controller

    {
        private readonly ApplicationDbContext _db;

        public IndiansController(ApplicationDbContext db)
        {
            _db = db;

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

     
