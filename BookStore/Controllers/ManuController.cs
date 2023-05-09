using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BookStore.Controllers;

public class ManuController : Controller
{
    public IActionResult Index()
    {
        var model = new ManuViewModel()
        {
            Name = "Nandhini"
        };
        return View(model);
    }
    [HttpPost]
    public IActionResult Update(ManuViewModel model)

    {       //diffirent implementation
            var name= model.Name;
        
            return RedirectToAction("Index");
        

    }

}
