using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebAPI.Controllers
{
     [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class DataController : ApiController
    {
        public HttpResponseMessage GetMenuCategory()
        {
            using (WebsiteEntities dc = new WebsiteEntities()) 
            {
                List<ProductCategory> Listcategory = new List<ProductCategory>();
                string UK = "MainCategory";
                ProductCategory cate = dc.ProductCategories.SingleOrDefault(a => a.KeyWord == UK);
                Listcategory = dc.ProductCategories.Where(x => x.ParentID == cate.CategoryID).OrderBy(x => x.SortOrder).ToList(); 
                HttpResponseMessage response;
                response = Request.CreateResponse(HttpStatusCode.OK, Listcategory);
                return response;
            }
        }
       
    }
}
