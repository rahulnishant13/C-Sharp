using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcDemo.Models;

namespace MvcDemo.Controllers
{
    public class EmployeeController : Controller
    {

        public ActionResult Details( int id)
        {
            //Employee employee = new Employee() 
            //{
            //    EmployeeId = 102,
            //    Name = "Rahul Nishant",
            //    Gender = "Male",
            //    City = "Banglore"
            //};

            EmployeeContext employeeContext = new EmployeeContext();
            Employee employee = employeeContext.Employee.Single(emp => emp.EmployeeId == id);

            return View(employee);
        }

    }
}
