using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Authorize]
    public class LoginController : ApiController
    {
        [AllowAnonymous]
        [HttpPost]
        [Route("login")]
        public IHttpActionResult Login(LoginRequest request)
        {
            if(request?.UserName=="admin" && request?.Password=="admin")
            {
                var token = JwtHelper.CreateJWTtoken(request);
                return Ok(new { success = true, jwt = token });
            }
            return Ok(new { success = false, msg = "Invalid Credentails" });
        }
        [HttpGet]
        [Route("home")]
        public IHttpActionResult Home()
        {
            return Ok("Home");
        }
        [HttpGet]
        [Route("admin")]
        [Authorize(Roles = "superadmin")]
        public IHttpActionResult Admin()
        {
            return Ok("SuperAdmin");
        }
    }
}
