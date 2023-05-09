using BookStore.Data;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class SchoolController : Controller


    {
        private readonly ApplicationDbContext _db;

        public SchoolController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            return View();
        }
        

        


        //        [HttpPost]

        //      public IActionResult Add(School obj)
        //        {

        //            {
        //                ModelState.AddModelError("Name", "The displayOrder cannot exactly match the name");
        //            }
        //            if (ModelState.IsValid)
        //            {
        //                _db.Schools.Add(obj);
        //                _db.SaveChanges();

        //                return RedirectToAction("Index");
        //            }
        //            return View(obj);
        //        }
    }
}