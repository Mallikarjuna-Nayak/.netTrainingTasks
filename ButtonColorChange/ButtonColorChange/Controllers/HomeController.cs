using ButtonColorChange.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ButtonColorChange.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult UserForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UserForm(UserForm formData)
        {
            if (ModelState.IsValid)
            {
                int pay_mode = Convert.ToInt32(formData.pay_mode);
                ViewData["username"] = formData.username;
                ViewData["pay_mode"] = ((pay_mode == 1) ? "Debit Card" : "Credit Card");
                ViewData["card_number"] = formData.card_number;
                return View();
            }
            return View();
        }
        public IActionResult ClientUsingCookie()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ClientUsingCookie(ClientUsingCookie formData)
        {
            if(ModelState.IsValid)
            {
                ViewData["username"] = formData.username;
                ViewData["address"] = formData.address;
                ViewData["dob"] = formData.dob;
                ViewData["nationality"] = formData.nationality;
                ViewData["country"] = formData.country;
                ViewData["skill"] = formData.skill;
                if (!HttpContext.Request.Cookies.ContainsKey(formData.username))
                {
                    HttpContext.Response.Cookies.Append(formData.username, DateTime.Now.ToString());
                    return Content("Welcome, new visitor! Thanks for registering with us, soon we will contact you.");
                }
                else
                {
                    DateTime firstRequest = DateTime.Parse(HttpContext.Request.Cookies[formData.username]);
                    return Content($"Welcome back, {formData.username}! You first visited us on: { firstRequest.ToString()} ");
                }
            }
            return View();
        }
        public IActionResult UniqueDigitNumber()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UniqueDigitNumber(UniqueDigitNumber postData)
        {
            if (ModelState.IsValid)
            {
                
                string data = postData.mobile_number;
                string output = new String(data.Distinct().ToArray());
                ViewData["uniqueData"] = output;
            }
            return View();
        }
        public IActionResult DisplayFlowers()
        {
            return View();
        }
        public IActionResult YourAction()
        {
            return Content("Test");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
