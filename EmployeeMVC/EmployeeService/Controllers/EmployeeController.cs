using EmployeeService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeService.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        [ActionName("GetEmployee")]
        public ActionResult GetEmployeesbyId(int id)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            Employee employee = employeeContext.employees.FirstOrDefault(emp => emp.EmpId == id);
            return View("GetEmployeesbyId",employee);
        }
    }
}