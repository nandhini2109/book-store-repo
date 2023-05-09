using BookStore.Data;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class NycController : Controller
    {
        private readonly ApplicationDbContext _db;

        public NycController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<MyNyc> objCategoryList = _db.Nyc;
            return View(objCategoryList);

        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(MyNyc obj)
        {

            _db.Nyc.Add(obj);
            _db.SaveChanges();

            return RedirectToAction("Index");


        }
        public IActionResult Edit(int? Id)
        {
            var obj = _db.Nyc.Find(Id);
            return View(obj);
     
        }
        [HttpPost]
        public IActionResult Edit(MyNyc obj)

        {   
                _db.Nyc.Update(obj);
                _db.SaveChanges();

                return RedirectToAction("Index");
            
           
        }
    }
}