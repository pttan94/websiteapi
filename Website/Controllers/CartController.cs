using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website.Models;

namespace Website.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Detail()
        {
            //using (ApplicationDbContext db = new ApplicationDbContext())
            //{
            //    ApplicationUser user = db.Users.SingleOrDefault(x => x.Id == "");
            //    user.UserName = User.Identity.Name;
            //}
            return View("Cart");
        }
    }
}