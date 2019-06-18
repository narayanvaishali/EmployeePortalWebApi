using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;
using Newtonsoft.Json;
using System.Collections;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Mvc;

namespace EmployeePortal.Models
{
    public class EmployeeDataAccessLayer
    {
        string connectionString = "local connection string details";

        //public dynamic GetEmployeeData(int ClientID, int occupationtypeid, string what)
        public dynamic GetEmployeeData(int employeeid)
        {
            dynamic jsonObject = new JObject();
            jsonObject.ClientID = 95212;
            jsonObject.Chrisname = "Saw1233";
            jsonObject.Surname = "BEAN";
            jsonObject.Address1 = "29 Kelber & dale Close";
            jsonObject.DOB = "1950-06-01T00,00,00";
            jsonObject.Email = "sabin.dangol@gmail.com";

            dynamic objEmp = new ExpandoObject();

            if (employeeid == 95212)
            {
                objEmp.staticdata = new dynamic[1];
                objEmp.staticdata[0] = new ExpandoObject();
                objEmp.staticdata[0] = jsonObject;
                return objEmp;
            }
            else
            {
               return null;
            }
            

          
            //using (var _conn = new SqlConnection(connectionString))
            //{

            //    var parameters = new DynamicParameters();
            //    parameters.Add("@ClientID", ClientID);
            //    parameters.Add("@occupationtypeid", occupationtypeid);
            //    parameters.Add("@what", what);

            //    var multiReader = _conn.QueryMultiple(@"GetClientStaticData", parameters,
            //       commandType: CommandType.StoredProcedure);

            //    dynamic objEmp = new ExpandoObject();
            //    objEmp.staticdata = multiReader.Read<dynamic>().ToArray();
            //    objEmp.NINOPrefix = multiReader.Read<dynamic>().ToArray();
            //    objEmp.Nationality = multiReader.Read<dynamic>().ToArray();

            //    return objEmp;
            //}

        }

            ////To View all employees details      
            //public IEnumerable<Employee> GetAllEmployees()
            //{
            //    List<Employee> lstemployee = new List<Employee>();

            //    using (SqlConnection con = new SqlConnection(connectionString))
            //    {
            //        SqlCommand cmd = new SqlCommand("spGetAllEmployees", con);
            //        cmd.CommandType = CommandType.StoredProcedure;

            //        con.Open();
            //        SqlDataReader rdr = cmd.ExecuteReader();

            //        while (rdr.Read())
            //        {
            //            Employee employee = new Employee();

            //            employee.ID = Convert.ToInt32(rdr["EmployeeID"]);
            //            employee.Name = rdr["Name"].ToString();
            //            employee.Gender = rdr["Gender"].ToString();
            //            employee.Department = rdr["Department"].ToString();
            //            employee.City = rdr["City"].ToString();

            //            lstemployee.Add(employee);
            //        }
            //        con.Close();
            //    }
            //    return lstemployee;
            //}

            ////To Add new employee record      
            //public void AddEmployee(Employee employee)
            //{
            //    using (SqlConnection con = new SqlConnection(connectionString))
            //    {
            //        SqlCommand cmd = new SqlCommand("spAddEmployee", con);
            //        cmd.CommandType = CommandType.StoredProcedure;

            //        cmd.Parameters.AddWithValue("@Name", employee.Name);
            //        cmd.Parameters.AddWithValue("@Gender", employee.Gender);
            //        cmd.Parameters.AddWithValue("@Department", employee.Department);
            //        cmd.Parameters.AddWithValue("@City", employee.City);

            //        con.Open();
            //        cmd.ExecuteNonQuery();
            //        con.Close();
            //    }
            //}

            ////To Update the records of a particluar employee    
            //public void UpdateEmployee(Employee employee)
            //{
            //    using (SqlConnection con = new SqlConnection(connectionString))
            //    {
            //        SqlCommand cmd = new SqlCommand("spUpdateEmployee", con);
            //        cmd.CommandType = CommandType.StoredProcedure;

            //        cmd.Parameters.AddWithValue("@EmpId", employee.ID);
            //        cmd.Parameters.AddWithValue("@Name", employee.Name);
            //        cmd.Parameters.AddWithValue("@Gender", employee.Gender);
            //        cmd.Parameters.AddWithValue("@Department", employee.Department);
            //        cmd.Parameters.AddWithValue("@City", employee.City);

            //        con.Open();
            //        cmd.ExecuteNonQuery();
            //        con.Close();
            //    }
            //}

            ////Get the details of a particular employee    
            //public Employee GetEmployeeData(int? id)
            //{
            //    Employee employee = new Employee();

            //    using (SqlConnection con = new SqlConnection(connectionString))
            //    {
            //        string sqlQuery = "SELECT * FROM tblEmployee WHERE EmployeeID= " + id;
            //        SqlCommand cmd = new SqlCommand(sqlQuery, con);

            //        con.Open();
            //        SqlDataReader rdr = cmd.ExecuteReader();

            //        while (rdr.Read())
            //        {
            //            employee.ID = Convert.ToInt32(rdr["EmployeeID"]);
            //            employee.Name = rdr["Name"].ToString();
            //            employee.Gender = rdr["Gender"].ToString();
            //            employee.Department = rdr["Department"].ToString();
            //            employee.City = rdr["City"].ToString();
            //        }
            //    }
            //    return employee;
            //}

            ////To Delete the record on a particular employee    
            //public void DeleteEmployee(int? id)
            //{

            //    using (SqlConnection con = new SqlConnection(connectionString))
            //    {
            //        SqlCommand cmd = new SqlCommand("spDeleteEmployee", con);
            //        cmd.CommandType = CommandType.StoredProcedure;

            //        cmd.Parameters.AddWithValue("@EmpId", id);

            //        con.Open();
            //        cmd.ExecuteNonQuery();
            //        con.Close();
            //    }
            //}

        }
}
