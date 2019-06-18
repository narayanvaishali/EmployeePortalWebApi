using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using EmployeePortal.Models;
using EmployeePortal.Interfaces;
using Microsoft.AspNetCore.Cors;
using Dapper;
using System.Dynamic;
using EmployeePortal.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeePortal.Controllers
{
    [EnableCors("AllowCors")]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _emp;

        public EmployeeController(IEmployeeService emp)
        {
            _emp = emp;
        }
        // GET api/shoppingcart
        [HttpGet]
        public dynamic Get()
        {
            var items = _emp.GetAllItems();
            return Ok(items);
        }

        // GET api/shoppingcart/5
        [HttpGet("{id}")]
        public dynamic Get(int id)
        {
            var item = _emp.GetById(id);

            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        // POST api/shoppingcart
        [HttpPost]
        public ActionResult Post([FromBody] Employee value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = _emp.Add(value);
            return CreatedAtAction("Get", new { EmployeeID = item.EmployeeID,
                Chrisname = item.Chrisname,
                Surname = item.Surname,
                Address1 = item.Address1,
                DOB = item.DOB,
                Email = item.Email
            }, item);
        }

        // DELETE api/shoppingcart/5
        [HttpDelete("{id}")]
        public ActionResult Remove(int id)
        {
            var existingItem = _emp.GetById(id);

            if (existingItem == null)
            {
                return NotFound();
            }

            _emp.Remove(id);
            return Ok();
        }

        /*
        // GET api/shoppingcart
        [HttpGet]
        //public dynamic <IEnumerable<Employee>> Get()

         public dynamic Get()
            {
                var employees = _emp.GetAllEmployees();
                return Ok(employees);
            }

        // GET api/shoppingcart/5
        [HttpGet("{id}")]
        //public dynamic GetEmployeeData(int employeeid)
        public dynamic Get(int employeeid)
        {
            var emp = _emp.GetEmployeeData(employeeid);

            if (emp == null)
            {
                return NotFound();
            }
            return Ok(emp);
        }

        //// GET api/shoppingcart/5
        //[HttpGet("{id}")]
        //public dynamic GetEmployeeData(int employeeid)
        //{
        //    var emp = _emp.GetEmployeeData(employeeid);

        //    if (emp == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(emp);
        //}

        // POST api/shoppingcart
        [HttpPost]
        // public ActionResult Post([FromBody] Employee value)
        public dynamic Save([FromBody] ExpandoObject value)
        {
          //  if (!ModelState.IsValid)
          if (value == null)
            {
                // return BadRequest(ModelState);
                return BadRequest();
            }

            var emp = _emp.Save(value);
            return CreatedAtAction("Get", new { employeeid = emp.EmployeeID}, emp);
        }

        // DELETE api/shoppingcart/5
        [HttpDelete("{id}")]
        //public ActionResult Remove(Guid id)
        public dynamic Remove(int employeeid)
        {
            var existingItem = _emp.GetEmployeeData(employeeid);

            if (existingItem == null)
            {
                return NotFound();
            }

            _emp.Remove(employeeid);
            return Ok();
        }*/

        /*
                // GET: api/<controller>
                [HttpGet]
                // public dynamic GetEmployeeData(int employeeid, int occupationtypeid, string what)
                public dynamic GetEmployeeData(int employeeid)
                {
                    ProfileDataAccessLayer objemployee = new ProfileDataAccessLayer();
                    var emp = objemployee.GetEmployeeData(employeeid);

                    if (emp == null)
                    {
                        return NotFound();
                    }

                    return Ok(emp);

                    //employeeid = 95212;
                    //occupationtypeid = 0;
                    //what = "OCCUPATION";
                    // return objemployee.GetEmployeeData(employeeid);
                    //return objemployee.GetEmployeeData(employeeid, occupationtypeid, what);
                }
        */
    }
}
