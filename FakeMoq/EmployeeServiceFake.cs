using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeePortal.Interfaces;
using Newtonsoft.Json.Linq;
using Dapper;
using System.Dynamic;
using EmployeePortal.Models;

namespace EmployeePortal.FakeMoq  
{
    public class EmployeeServiceFake : IEmployeeService
    {
        // private readonly ExpandoObject _emp;

        private readonly List<Employee> _emp;

        public EmployeeServiceFake()
        {
            _emp = new List<Employee>()
            {
                new Employee()  { EmployeeID = 95212,  Chrisname = "Saw1233", Surname = "BEAN",
                    Address1 = "29 Kelber & dale Close",
                    DOB = "1950-06-01T00,00,00" , Email = "sabin.dangol@gmail.com"
                }               
            };
        }

        public IEnumerable<Employee> GetAllItems()
        {
            return _emp;
        }

        public Employee Add(Employee newItem)
        {
          //  newItem.EmployeeID = Guid.NewGuid();
            _emp.Add(newItem);
            return newItem;
        }

        public Employee GetById(int id)
        {
            return _emp.Where(a => a.EmployeeID == id)
                .FirstOrDefault();
        }

        public void Remove(int id)
        {
            var existing = _emp.First(a => a.EmployeeID == id);
            _emp.Remove(existing);
        }

        
        //************************************************************************************
        //public EmployeeServiceFake()
        //{
        //_emp = new List<dynamic>()
        //{

        //  /*  jsonObject.ClientID = 95212;
        //    jsonObject.Chrisname = "Saw1233";
        //    jsonObject.Surname = "BEAN";
        //    jsonObject.Address1 = "29 Kelber & dale Close";
        //    jsonObject.DOB = "1950-06-01T00,00,00";
        //    jsonObject.Email = "sabin.dangol@gmail.com";
        //    */

        //new { EmployeeID = 95212,
        //      Chrisname = "Saw1233",
        //      Surname = "BEAN", Address1 = "29 Kelber & dale Close", DOB = "1950-06-01T00,00,00",
        //      Email = "sabin.dangol@gmail.com"
        //    }
        //};

        //dynamic jsonObject = new JObject();
        //jsonObject.EmployeeID = 95212;
        //jsonObject.Chrisname = "Saw1233";
        //jsonObject.Surname = "BEAN";
        //jsonObject.Address1 = "29 Kelber & dale Close";
        //jsonObject.DOB = "1950-06-01T00,00,00";
        //jsonObject.Email = "sabin.dangol@gmail.com";

        //dynamic objEmp = new ExpandoObject();

        ////if (employeeid == 95212)
        ////{
        //    objEmp.staticdata = new dynamic[1];
        //    objEmp.staticdata[0] = new ExpandoObject();
        //    objEmp.staticdata[0] = jsonObject;
        //    _emp = objEmp;
        //  return objEmp;
        //}
        //else
        //{
        //    return null;
        //}
        // }

        //public ExpandoObject GetAllEmployees()
        //{
        //    return _emp;
        //}

        //public dynamic Save(ExpandoObject newEmp)
        //{
        //    // _emp.Add(newEmp);
        //   // _emp.
        //    return newEmp;
        //}

        //public dynamic GetEmployeeData(int employeeid)
        //{
        //    return _emp.Where(a => a.EmployeeID == employeeid)
        //        .FirstOrDefault();
        //}

        //public void Remove(int employeeid)
        //{
        //    var existing = _emp.First(a => a.employeeid == employeeid);
        //    _emp.Remove(existing);
        //}
    }


}
