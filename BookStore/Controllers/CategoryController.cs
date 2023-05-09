using BookStore.Data;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            //var objectCategoryList = _db.Categories.ToList();
            IEnumerable<Category> objCategoryList = _db.Categories;
            return View(objCategoryList);

        }
        // This action method is for Add category page
        public IActionResult Add()
        {
            return View();
        }
        //This is for adding category iteams to database  formpost from add page

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("Name", "The displayOrder cannot exactly match the name");
            }
            if (ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult Edit(int? Id)
        {
            var obj = _db.Categories.Find(Id);
            return View(obj);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Edit(Category obj)

        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("Name", "The displayOrder cannot exactly match the name");
            }
            if (ModelState.IsValid)
            {
                _db.Categories.Update(obj);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(obj);
        }

        // This is for Edit page only. Index page will send Id to Tofetch database. edit page lo pre deflut  values ni chuinchadaniki
        public IActionResult Delete(int? Id)
        {
            var obj = _db.Categories.Find(Id);
            return View(obj);
        }

        // This is for unna values ni Delete cheyadaniki.edit form meda formpost chesinapudu a values ekkada vosthai
        [HttpPost]
        public IActionResult Delete(Category obj)
        {
            _db.Categories.Remove(obj);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}








