using EmployeeLatest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using EmployeeLatest.ViewModel;

namespace EmployeeLatest.Controllers
{
    public class EmployeesController : Controller
    {
        private ApplicationDbContext _context;


        public EmployeesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Employees
        public ActionResult Index()
        {
            var employee = _context.EmployeeSalaries.Include(c => c.Employee).ToList();
            return View(employee);
        }

        // GET: Employees/New
        public ActionResult New()
        {
            var departmentTypes = _context.Departments.ToList();


            var viewModel = new EmployeeViewModel
            {
                Employee = new Employee(),
                Department = departmentTypes,
                EmployeeSalary = new EmployeeSalary()
            };

            return View("New", viewModel);
        }

        [HttpPost]
        public ActionResult Save(EmployeeSalary employeeS)
        {
            if (employeeS.Id == 0)
            {

              // _context.Employees.Add(employee);
                _context.EmployeeSalaries.Add(employeeS);


            }
            else
            {
               // var empInDb = _context.Employees.Single(m => m.EmpId == employee.EmpId);
                var empInDbS = _context.EmployeeSalaries.Single(m => m.Id == employeeS.Id);
                empInDbS.EmpName = employeeS.EmpName;
                empInDbS.DepaId = employeeS.DepaId;
                empInDbS.Salary = employeeS.Salary;

            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Employees");
        }

    }
}