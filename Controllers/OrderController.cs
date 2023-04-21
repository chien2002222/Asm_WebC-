using FPTBook.Data;
using FPTBook.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Net;

namespace FPTBook.Controllers
{
    public class OrderController : Controller
    {
        public ApplicationDbContext context { get; set; }
        public OrderController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [Authorize (Roles = "Customer")]
        public IActionResult MakeOrder(int id, int quantity, string customerName, int price)
        {
            TempData["ok"] = "Order successfully !";
            var order = new Order();
            order.Status = -1;
            order.Price = price;
            order.OrderQuantity = quantity;
            order.BookId = id;
            order.Customer = customerName;
            order.OrderName = context.Books.Find(id).Title;
            order.OrderPrice = (context.Books.Find(id).Price)*quantity;
            
            context.Orders.Add(order);
            context.SaveChanges();
            return View(order);
        }

        public IActionResult CancelOrder(int id)
        {
            var order = context.Orders.Find(id);
            context.Orders.Remove(order);
            context.SaveChanges();
            return Redirect("~/Client/Store");
        }

        [Authorize(Roles = "BookOwner")]
        public IActionResult Record()
        {
            var customerOrder = context.Orders.ToList();
           
            return View(customerOrder) ;
        }

        [Authorize (Roles = "BookOwner")]
        public IActionResult Approve(int id, int quantity, int bookId)
        {
            TempData["approve"] = "Order has been approved";
            var order = context.Orders.Find(id);
            var name = context.Orders.Where(x=>x.Id == id).First().OrderName;
            context.Books.Where(x => x.Title == name).First().Quantity -= quantity;
            context.Orders.Where(x => x.Id == id).First().Status = 1;
            context.SaveChanges();
            return RedirectToAction("Record");
        }

        [Authorize(Roles = "BookOwner")]
        public IActionResult Cancel(int id)
        {
            TempData["cancel"] = "Order has been cancelled";
            var order = context.Orders.Find(id);
            context.Orders.Where(x => x.Id == id).First().Status = 0;
            context.SaveChanges();
            return RedirectToAction("Record");

        }
    }
}
