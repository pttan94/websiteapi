using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Website.Models;

namespace Website.Controllers
{
    public class CheckoutController : Controller
    {
        // GET: Checkout
        public ActionResult Detail()
        {
            //IUser user;
            //using (ApplicationDbContext db = new ApplicationDbContext())
            //{
            //    user = db.Users.FirstOrDefault(x => x.Id == User.Identity.GetUserId());
            //}
            return View("Checkout");
        }
    }
}