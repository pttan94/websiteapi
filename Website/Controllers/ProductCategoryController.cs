using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Website.Controllers
{
    public class ProductCategoryController : Controller
    {
        // GET: ProductCategory
        public ActionResult Detail(int CategoryID)
        {
            //ProductCategory Product = new ProductCategory();
            ////List<ProductCategory> list = new List<ProductCategory>();
            //string host = ConfigurationManager.AppSettings["APIHost"];
            //string controllerName = "ProductCategory";

            //HttpClient client = new HttpClient();
            //var result = client.GetAsync(string.Format("{0}/api/{1}?CategoryID={2}", host, controllerName,CategoryID)).Result;
            //if (result.IsSuccessStatusCode)
            //{
            //    Product = result.Content.ReadAsAsync<ProductCategory>().Result;
            //}

            //return PartialView(Product);

            return View(CategoryID);
        }

        public PartialViewResult ProductCategoryPartial() 
        {
            string UK = "MainCategory";
            //List<ProductCategory> list = new List<ProductCategory>();
            //string host = ConfigurationManager.AppSettings["APIHost"];
            //string controllerName = "ProductCategory";

            //HttpClient client = new HttpClient();
            //var result = client.GetAsync(string.Format("{0}/api/{1}?KeyWord={2}", host, controllerName, UK)).Result;
            //if (result.IsSuccessStatusCode)
            //{
            //    list = result.Content.ReadAsAsync<List<ProductCategory>>().Result;
            //}
            //ViewBag.host = host;

            return PartialView();
            
        }
    }
}