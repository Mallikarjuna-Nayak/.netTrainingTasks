using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class ProductController : ApiController
    {
        private WEBAPI_DBEntities db = new WEBAPI_DBEntities();
        [HttpGet]
        public IHttpActionResult GetAllProducts()
        {
            List<Product> list = db.Products.ToList();
            return Ok(list);
        }
        [HttpGet]
        public IHttpActionResult GetProductById(int id)
        {
            var prod = db.Products.Where(model => model.ProductId == id).FirstOrDefault();
            return Ok(prod);
        }
        [HttpPost]
        public IHttpActionResult ProductInsert(Product prod)
        {
            db.Products.Add(prod);
            db.SaveChanges();
            return Ok();
        }
        [HttpPut]
        public IHttpActionResult ProductUpdate(Product prod)
        {
            //db.Entry(prod).State = System.Data.Entity.EntityState.Modified;
            //db.SaveChanges();
            var p = db.Products.Where(model=>model.ProductId==prod.ProductId).FirstOrDefault();
            if(p != null)
            {
                p.ProductId = prod.ProductId;
                p.ProductName = prod.ProductName;
                p.Quantity = prod.Quantity;
                p.Price = prod.Price;
                db.SaveChanges();
            }
            else
            {
                return NotFound();
            }
            return Ok();
        }
        [HttpDelete]
        public IHttpActionResult ProductDelete(int id)
        {
            var prod = db.Products.Where(model => model.ProductId == id).FirstOrDefault();
            db.Entry(prod).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            return Ok();
        }
    }
}
