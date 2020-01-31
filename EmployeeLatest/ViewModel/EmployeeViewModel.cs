using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeLatest.Models;

namespace EmployeeLatest.ViewModel
{
    public class EmployeeViewModel
    {
        public Employee Employee { get; set; }
        public IEnumerable<Department> Department { get; set; }
        public EmployeeSalary EmployeeSalary { get; set; }
        public string Title
        {
            get
            {
                if (Employee != null && Employee.EmpId != 0)
                    return "Edit Employee";

                return "New Employee";
            }
        }
    }
}