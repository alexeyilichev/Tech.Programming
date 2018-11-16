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
        private static Database _db = new Database();
        public ActionResult Index()
        {
            return View();
        }
        #region Orders
        public ActionResult GetOrders()
        {
            return PartialView("_Orders");
        }
        public ActionResult Orders_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(GetOrdersEnum().ToDataSourceResult(request));
        }
        private static IEnumerable<Orders> GetOrdersEnum()
        {
            var northwind = _db;

            return northwind.Orders.AsEnumerable().Select(order => new Orders
            {
                Id = order.Id,
                Name = order.Name,
                Count = order.Count,
                Price = order.Price,
                Place = order.Place
            });
        }
        #endregion

        #region MyOrder

        public ActionResult GetMyOrder()
        {
            return PartialView("_MyOrder");
        }

        #endregion

        #region Sellers

        public ActionResult GetSellers()
        {
            return PartialView("_Sellers");
        }

        #endregion

        #region MyItems

        public ActionResult GetMyItems()
        {
            return PartialView("_MyItems");
        }

        #endregion

        #region Authorize

        public ActionResult GetAuthorize()
        {
            ViewBag.Name = "Alex";
            return PartialView("_Authorize");
        }

        #endregion
    }
}
