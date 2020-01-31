using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeLatest.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public Department Department { get; set; }
        public int DepaId { get; set; }
        public string DepaName { get; set; }
    }
}