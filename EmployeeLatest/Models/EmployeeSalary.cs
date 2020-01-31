using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeLatest.Models
{
    public class EmployeeSalary
    {
        
        public int Id { get; set; }
        public string Salary { get; set; }
        public Employee Employee { get; set; }
        public int EmpId { get; set; }
        public int DepaId { get; set; }
        public string EmpName { get; set; }
        public string DepaName { get; set; }

    }
}