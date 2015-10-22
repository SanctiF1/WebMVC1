using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMVC1 .DataAccessLayer;

namespace WebMVC1.Models
{
    public class EmployeeBusinessLayer
    {

        //public bool IsValidUser(UserDetails u)
        //{
        //    if (u.UserName == "Admin" && u.Password == "Admin")
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        public UserStatus GetUserValidity(UserDetails u)
        {
            if (u.UserName == "Admin" && u.Password == "Admin")
            {
                return UserStatus.AuthenticatedAdmin;
            }
            else if (u.UserName == "Sukesh" && u.Password == "Sukesh")
            {
                return UserStatus.AuthentucatedUser;
            }
            else
            {
                return UserStatus.NonAuthenticatedUser;
            }
        }

        public List<Employee> GetEmployees()
        {
            SalesERPDAL salesDal = new SalesERPDAL();
            return salesDal.Employees.ToList();
        }
        public Employee SaveEmployee(Employee e)
        {
            SalesERPDAL salesDal = new SalesERPDAL();
            salesDal.Employees.Add(e);
            salesDal.SaveChanges();
            return e;
        }
        //public List<Employee> GetEmployees()
        //{
        //    List<Employee> employees = new List<Employee>();
        //    Employee emp = new Employee();
        //    emp.FirstName = "johnson";
        //    emp.LastName = " fernandes";
        //    emp.Salary = 14000;
        //    employees.Add(emp);

        //     emp = new Employee();
        //    emp.FirstName = "boy";
        //    emp.LastName = " cow";
        //    emp.Salary = 1000;
        //    employees.Add(emp);

        //    emp = new Employee();
        //    emp.FirstName = "hell";
        //    emp.LastName = " baby";
        //    emp.Salary = 2000000;
        //    employees.Add(emp);
        //    return employees;
        //}

        public void UploadEmployees(List<Employee> employees)
        {
            SalesERPDAL salesDal = new SalesERPDAL();
            salesDal.Employees.AddRange(employees);
            salesDal.SaveChanges();
        }
    }
}