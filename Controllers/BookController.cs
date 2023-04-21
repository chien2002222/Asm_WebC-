using FPTBook.Data;
using FPTBook.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FPTBook.Controllers
{
    public class BookController : Controller
    {
        public readonly ApplicationDbContext context;

        public BookController(ApplicationDbContext context)
        {
            this.context = context;
        }

        //[Authorize(Roles = "BookOwner")]
        public IActionResult Index()
        {
            var categories = context.Categories.ToList();
            ViewBag.Categories = categories;
            return View(context.Books.ToList());
        }

        public IActionResult Detail(int id)
        {
            var categories = context.Categories.ToList();
            var book = context.Books.Find(id);
            return View(book);
        }

        //[Authorize(Roles = "BookOwner")]
        [HttpGet]
        public IActionResult Add()
        {
            var categories = context.Categories.ToList();
            ViewBag.Categories = categories;
            return View();
        }

        [HttpPost]
        public IActionResult Add(Book book)
        {
            if(ModelState.IsValid)
            {
                context.Books.Add(book);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Categories = context.Categories.ToList();
            return View(book);
        }

        //[Authorize(Roles = "BookOwner")]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var categories = context.Categories.ToList();
            ViewBag.Categories = categories;
            var books = context.Books.Find(id);
            return View(books);
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if(ModelState.IsValid)
            {
                context.Books.Update(book);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Categories = context.Categories.ToList();
            return View(book);
        }

        //[Authorize(Roles = "BookOwner")]
        public IActionResult Delete(int? id)
        {
            if(id == null) return NotFound();
            else
            {
                   var book = context.Books.Find(id);
                   context.Books.Remove(book);
                   context.SaveChanges();
                   return RedirectToAction("Index");
            }
        }

     

       
    }
}
