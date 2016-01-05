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
    public class ProductController : ApiController
    {
        
        public HttpResponseMessage GetProduct(string UK)
        {
            using (WebsiteEntities dc = new WebsiteEntities())
            {
                List<Product> Products = new List<Product>();
                ProductCategory cate = dc.ProductCategories.SingleOrDefault(a => a.KeyWord == UK);
                Products = (from c in dc.ProductCategories
                            from p in dc.Products
                            from pc in dc.ProductToCategories
                            where c.CategoryID == pc.CategoryID && pc.ProductID == p.ProductID
                            && c.CategoryID == cate.CategoryID
                            && p.Status == true
                            select p).ToList();

                HttpResponseMessage response;
                response = Request.CreateResponse(HttpStatusCode.OK, Products);
                return response;
            }
        }
        public HttpResponseMessage GetProduct(int  CategoryID)
        {
            using (WebsiteEntities dc = new WebsiteEntities())
            {
                List<Product> Products = new List<Product>();
                Products = (from c in dc.ProductCategories
                            from p in dc.Products
                            from pc in dc.ProductToCategories
                            where c.CategoryID == pc.CategoryID && pc.ProductID == p.ProductID
                            && c.CategoryID == CategoryID
                            && p.Status == true
                            select p).ToList();
                HttpResponseMessage response;
                response = Request.CreateResponse(HttpStatusCode.OK, Products);
                return response;
            }
        }

        public HttpResponseMessage GetProductDetail(int ProductID)
        {
            using (WebsiteEntities db = new WebsiteEntities())
            {
                Product product = db.Products.FirstOrDefault(x => x.ProductID == ProductID);

                HttpResponseMessage response;
                response = Request.CreateResponse(HttpStatusCode.OK, product);
                return response;
            }
        }
        public HttpResponseMessage GetProductRelated(int ProductRelatedID)
        {
            using (WebsiteEntities db = new WebsiteEntities())
            {
                List<Product> Products = new List<Product>();

                ProductToCategory pc1 = db.ProductToCategories.First(a => a.ProductID == ProductRelatedID);
                ProductCategory cate = db.ProductCategories.SingleOrDefault(a => a.CategoryID == pc1.CategoryID);
                Products = (from c in db.ProductCategories
                            from p in db.Products
                            from pc in db.ProductToCategories
                            where c.CategoryID == pc.CategoryID && pc.ProductID == p.ProductID
                            && c.CategoryID == cate.CategoryID
                            && p.Status == true
                            && p.ProductID != ProductRelatedID
                            select p).Take(4).ToList();
                HttpResponseMessage response;
                response = Request.CreateResponse(HttpStatusCode.OK, Products);
                return response;
            }
        }
    }
}
