using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Dynamic;
using EmployeePortal.Models;

namespace EmployeePortal.Interfaces
{
    //public interface IEmployeeService
    //{
    //    // List<dynamic> Get();
    //    dynamic GetAllEmployees();
    //    dynamic Save(ExpandoObject newItem);
    //    dynamic GetEmployeeData(int employeeid);
    //    void Remove(int employeeid);
    //}
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAllItems();
        Employee Add(Employee newItem);
        Employee GetById(int employeeid);
        void Remove(int employeeid);
    }
}
