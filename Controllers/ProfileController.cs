using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeePortal.Models;
using EmployeePortal.Interfaces;

using Microsoft.AspNetCore.Cors;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeePortal.Controllers
{

    [EnableCors("AllowCors")]
    [Route("api/[controller]")]
    public class ProfileController : ControllerBase
    {
        private readonly IEmployeeService _emp;

        public ProfileController(IEmployeeService emp)
        {
            _emp = emp;
        }

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
