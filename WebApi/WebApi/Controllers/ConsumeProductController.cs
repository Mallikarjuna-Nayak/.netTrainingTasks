using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class ConsumeProductController : Controller
    {
        HttpClient hc = new HttpClient();

        // GET: ConsumeProduct
        public ActionResult Index()
        {
            List<Product> prod_list = new List<Product>();
            hc.BaseAddress = new Uri("https://localhost:44346/Api/Product");
            var response = hc.GetAsync("Product");
            response.Wait();
            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<List<Product>>();
                display.Wait();
                prod_list = display.Result;
            }
            return View(prod_list);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product prod)
        {
            hc.BaseAddress = new Uri("https://localhost:44346/Api/Product");
            var response = hc.PostAsJsonAsync<Product>("Product", prod);
            response.Wait();
            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View("Create");
        }
        public ActionResult Details(int id)
        {
            Product prod = null;
            hc.BaseAddress = new Uri("https://localhost:44346/Api/Product");
            var response = hc.GetAsync("Product/" + id.ToString());
            response.Wait();
            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<Product>();
                display.Wait();
                prod = display.Result;
            }
            return View(prod);
        }
        public ActionResult Edit(int id)
        {
            Product prod = null;
            hc.BaseAddress = new Uri("https://localhost:44346/Api/Product");
            var response = hc.GetAsync("Product/" + id.ToString());
            response.Wait();
            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<Product>();
                display.Wait();
                prod = display.Result;
            }
            return View(prod);
        }
        [HttpPost]
        public ActionResult Edit(Product prod)
        {
            hc.BaseAddress = new Uri("https://localhost:44346/Api/Product");
            var response = hc.PutAsJsonAsync<Product>("Product", prod);
            response.Wait();
            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View("Edit");
        }
        public ActionResult Delete(int id)
        {
            Product prod = null;
            hc.BaseAddress = new Uri("https://localhost:44346/Api/Product");
            var response = hc.GetAsync("Product/" + id.ToString());
            response.Wait();
            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<Product>();
                display.Wait();
                prod = display.Result;
            }
            return View(prod);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            hc.BaseAddress = new Uri("https://localhost:44346/Api/Product");
            var response = hc.DeleteAsync("Product/" + id.ToString());
            response.Wait();
            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View("Delete");
        }
    }
}