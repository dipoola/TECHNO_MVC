using Microsoft.AspNetCore.Mvc;
using TECHNO_MVC.Data;
using TECHNO_MVC.Models;

namespace TECHNO_MVC.Controllers
{
    public class CategoryController : Controller
    { private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList = _db.Categories1;
            return View(objCategoryList);
        }


        //GET
        public IActionResult Create()
        {
           
            return View();
        }  



        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category obj)
        {   
            if(obj.Name== obj.DisplayOrder.ToString())
            {

                ModelState.AddModelError("CustomError","The DisplayOrder cannot exactly match the name.");
            }
            if (ModelState.IsValid)
            {
                _db.Categories1.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
