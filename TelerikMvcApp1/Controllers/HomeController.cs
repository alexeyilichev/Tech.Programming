using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TelerikMvcApp1.Models;

namespace TelerikMvcApp1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }
        public ActionResult GetOrders()
        {
            var result = new Order().Orders.Select(i => new Orders
            {
                Name = i.Name,
                Count = i.Count,
                Price = i.Price,
                Place = i.Place
            }
            ).ToList();

            return PartialView("_Orders", result);
        }
    }
}
