using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeService;
using EmployeeService.Models;

namespace EmployeeService.Test
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void GetEmployeeFirstName()
        {
            EmployeeContext employeeContext = new EmployeeContext();
            Employee employee = employeeContext.employees.FirstOrDefault(emp => emp.EmpId == 1001);
            Assert.AreEqual("Abdul1", employee.FirstName);
        }
    }
}
