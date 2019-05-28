using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EmployeeService.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int? EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public double Salary { get; set; }
    }
}