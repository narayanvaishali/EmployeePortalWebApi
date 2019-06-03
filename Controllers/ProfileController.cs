using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StrongBox.Models;

using Microsoft.AspNetCore.Cors;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StrongBox.Controllers
{
    [EnableCors("AllowCors")]
    [Route("api/[controller]")]
    public class ProfileController : ControllerBase
    {
        // GET: api/<controller>
        [HttpGet]
        public dynamic GetEmployeeData(int employeeid, int occupationtypeid, string what)
        {
            ProfileDataAccessLayer objemployee = new ProfileDataAccessLayer();

            employeeid = 95212;
            occupationtypeid = 0;
            what = "OCCUPATION";
            return objemployee.GetEmployeeData(employeeid, occupationtypeid, what);
        }

    }
}
