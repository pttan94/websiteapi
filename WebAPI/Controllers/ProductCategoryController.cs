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
    public class ProductCategoryController : ApiController
    {
         public HttpResponseMessage GetCategory(int CategoryID)
         {
             using (WebsiteEntities dc = new WebsiteEntities())
             {
                 ProductCategory cate = dc.ProductCategories.SingleOrDefault(a => a.CategoryID == CategoryID);
                 HttpResponseMessage response;
                 response = Request.CreateResponse(HttpStatusCode.OK, cate);
                 return response;
             }
         }

         public HttpResponseMessage GetCategoryList(String KeyWord)
         {
             using (WebsiteEntities dc = new WebsiteEntities())
             {
                 ProductCategory mainCate = dc.ProductCategories.SingleOrDefault(cate => cate.KeyWord == KeyWord);

                 List<ProductCategory> list =(from cate in dc.ProductCategories 
                                             where cate.ParentID==mainCate.CategoryID
                                                  select cate).ToList();
                 HttpResponseMessage response;
                 response = Request.CreateResponse(HttpStatusCode.OK, list);
                 return response;
             }
         }
       

    }
}
