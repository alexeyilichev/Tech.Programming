using System;
﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using TelerikMvcApp1.Models;

namespace TelerikMvcApp1.Controllers
{
	public partial class GridController : Controller
    {
		public ActionResult Orders_Read()
		{
			var result = Enumerable.Range(0, 3).Select(i => new Orders
			{
				Id = i
			});

            return PartialView("_Orders", result);
		}
	}
}
