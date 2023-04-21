using FPTBook.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Data;
using System.Linq;

namespace FPTBook.Controllers
{

    public class ClientController : Controller
    {
        public readonly ApplicationDbContext context;
        public ClientController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult Store()
        {
            return View(context.Books.ToList());
        }

        public IActionResult Detail(int id)
        {
            var cate = context.Categories.ToList();
            var books = context.Books.Find(id);
            return View(books);
        }
        
        [HttpPost]
        public IActionResult Search(string keyword)
        {
            var books = context.Books.Where(x=>x.Title.Contains(keyword)).ToList();
            if(books.Count == 0)
            {
                TempData["Message"] = "No book found";
            }
            return View("Store", books);
        }
       
        public IActionResult SortAscName()
        {
            var books = context.Books.OrderBy(x => x.Title).ToList();
            return View("Store", books);
        }
        public IActionResult SortDscName()
        {
            var books = context.Books.OrderByDescending(x => x.Title).ToList();
            return View("Store", books);
        }

        public IActionResult SortAscPrice()
        {
            var books = context.Books.OrderBy(x => x.Price).ToList();
            return View("Store", books);
        }

        public IActionResult SortDscPrice()
        {
            var books = context.Books.OrderByDescending(x => x.Price).ToList();
            return View("Store", books);
        }

    }
}
