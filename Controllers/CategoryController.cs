using FPTBook.Data;
using FPTBook.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq;

namespace FPTBook.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext context;

        public CategoryController(ApplicationDbContext context)
        {
            this.context = context;
        }

       
        public IActionResult Index()
        {
            var categories = context.Categories.ToList();
            return View(categories);
        }

        public IActionResult Info(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var category = context.Categories.Include(c => c.Books).FirstOrDefault(c => c.Id == id);
            return View(category);
        }

     /*   [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Category category)
        {
            if (ModelState.IsValid)
            {
                context.Categories.Add(category);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);
        }*/

        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public IActionResult Edit(int id)
        {
            var cate = context.Categories.Find(id);
            return View(cate);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                context.Categories.Update(category);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult Delete(int id)
        {
            TempData["Message"] = "Delete successfully";
            var category = context.Categories.Find(id);
            context.Categories.Remove(category);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "BookOwner")]
        [HttpGet]
        public IActionResult Request()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Request(Request request)
        {
            TempData["Message"] = "Submitted successfully. Request is waiting for approval";
            context.Requests.Add(request);
            context.SaveChanges();
            return View();
        }
    }
}
