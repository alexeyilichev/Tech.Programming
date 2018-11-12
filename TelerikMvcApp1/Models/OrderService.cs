using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelerikMvcApp1.Models
{
    public class OrderService
    {
        private static bool UpdateDatabase = false;
        private Order entities;

        public OrderService(Order entities)
        {
            this.entities = entities;
        }
        public IList<Orders> GetAll()
        {
            var result = HttpContext.Current.Session["_Orders"] as IList<Orders>;
            if (result == null || UpdateDatabase)
            {
                result = entities.Orders.Select(product => new Orders
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    Count = product.Count,
                    Place = product.Place
                }).ToList();

                HttpContext.Current.Session["_Orders"] = result;
            }
            return result;
        }
        public IEnumerable<Orders> Read()
        {
            return GetAll();
        }
    }
}