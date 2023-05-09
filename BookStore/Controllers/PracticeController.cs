using BookStore.Data;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace BookStore.Controllers
{
    public class PracticeController : Controller
    {

        private readonly ApplicationDbContext _db;

        public PracticeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<MyPractice> objCategoryList = _db.Practice;
            return View(objCategoryList);

        }
        public IActionResult Add()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Add(MyPractice obj)
        {

            _db.Practice.Update(obj);
            _db.SaveChanges();

            return RedirectToAction("Index");

        }

        public IActionResult Edit(int? Id)
        {
            var obj = _db.Practice.Find(Id);
            return View(obj);
        }

        [HttpPost]

        public IActionResult Edit(MyPractice obj)
            
          
            {
                _db.Practice.Update(obj);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

        public IActionResult Delete(int? Id)
        {
            var obj = _db.Practice.Find(Id);
            return View(obj);
        }

        [HttpPost]
        public IActionResult Delete(MyPractice obj)
        {
            _db.Practice.Remove(obj);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

    }

}    
        
    
 


