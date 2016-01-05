using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace Website.Controllers
{
    public class ProductController : Controller
    {

        public ActionResult Detail(int? ProductID)
        {
            // if (ProductID == null)
            //      return View("ListStudent");
            return View(ProductID);
        }
    }
}
