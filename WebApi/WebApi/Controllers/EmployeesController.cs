using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class EmployeesController : ApiController
    {
        private WEBAPI_DBEntities db = new WEBAPI_DBEntities();
        [HttpGet]
        public IHttpActionResult GetAllEmployees()
        {
            List<Employee> list = db.Employees.OrderByDescending(x => x.ID).ToList();
            return Ok(list);
        }

        [HttpGet]
        public IHttpActionResult GetEmpById(int id)
        {
            Employee data = db.Employees.Where(x => x.ID == id).SingleOrDefault();
            return Ok(data);
        }

        [HttpPost]
        public IHttpActionResult Insert(Employee emp)
        {
            db.Employees.Add(emp);
            db.SaveChanges();
            return Ok();
        }
        [HttpPut]
        public IHttpActionResult Update(Employee emp)
        {
            Employee e = db.Employees.Where(x => x.ID == emp.ID).SingleOrDefault();
            if(e != null)
            {
                e.FirstName = emp.FirstName;
                e.LastName = emp.LastName;
                e.Gender = emp.Gender;
                e.Salary = emp.Salary;
                db.SaveChanges();
            }
            else
            {
                return NotFound();
            }            
            return Ok();
        }
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            Employee data = db.Employees.Where(x => x.ID == id).SingleOrDefault();
            db.Employees.Remove(data);
            db.SaveChanges();
            return Ok();
        }
                
    }
}
