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
            return View();
        }
        public ActionResult GetOrders()
        {
                return PartialView("_Orders");
        }
        public ActionResult Orders_Read(Orders model)
        {
                return PartialView("_Orders", model);
        }
    }
}
