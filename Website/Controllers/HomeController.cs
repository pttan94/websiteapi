using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Website.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //List<ProductCategory> list = new List<ProductCategory>();
            //HttpClient client = new HttpClient();
            //var result = client.GetAsync("http://localhost:13532/api/Data").Result;
            //if (result.IsSuccessStatusCode)
            //{
            //    list = result.Content.ReadAsAsync<List<ProductCategory>>().Result;
            //}
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}