using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class ConsumeEmpController : Controller
    {
        private HttpClient hc = new HttpClient();
        // GET: ConsumeEmp
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Display()
        {
            List<Employee> list = new List<Employee>();
            hc.BaseAddress = new Uri("https://localhost:44346/Api/Employees");
            var consume = hc.GetAsync("Employees");
            consume.Wait();
            var test = consume.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<List<Employee>>();
                display.Wait();
                list = display.Result;
            }
            return View(list);
        }
        public ActionResult PostData()
        {
            return View();
        }
        [HttpPost]
        public ActionResult PostData(Employee data)
        {
            hc.BaseAddress = new Uri("https://localhost:44346/Api/Employees");
            var consume = hc.PostAsJsonAsync("Employees", data);
            consume.Wait();
            var test = consume.Result;
            if(test.IsSuccessStatusCode)
            {
                return RedirectToAction("Display");
            }
            return View("PostData");
        }
        public ActionResult Details(int id)
        {
            Employee data = new Employee();
            hc.BaseAddress = new Uri("https://localhost:44346/Api/Employees");
            var consume = hc.GetAsync("Employees/" + id.ToString());
            consume.Wait();
            var test = consume.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<Employee>();
                display.Wait();
                data = display.Result;
            }
            return View(data);
        }
        public ActionResult Edit(int id)
        {
            Employee emp = null;
            hc.BaseAddress = new Uri("https://localhost:44346/Api/Employees");
            var consume = hc.GetAsync("Employees/" + id.ToString());
            consume.Wait();
            var test = consume.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<Employee>();
                display.Wait();
                emp = display.Result;
            }
            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(Employee emp)
        {
            hc.BaseAddress = new Uri("https://localhost:44346/Api/Employees");
            var consume = hc.PutAsJsonAsync<Employee>("Employees", emp);
            consume.Wait();
            var test = consume.Result;
            if (test.IsSuccessStatusCode)
            {
                return RedirectToAction("Display");
            }
            return View("Edit");
        }
        public ActionResult Deletedata(int id)
        {
            Employee data = new Employee();
            hc.BaseAddress = new Uri("https://localhost:44346/Api/Employees");
            var consume = hc.DeleteAsync("Employees/" + id.ToString());
            consume.Wait();
            var test = consume.Result;
            if(test.IsSuccessStatusCode)
            {
                return RedirectToAction("Display");
            }
            return View();
        }
    }
}