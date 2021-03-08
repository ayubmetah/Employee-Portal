using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Employee_Portal.Models;

namespace Employee_Portal.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View(Repository.AllEmployees);
        }

        // HTTP GET VERSION
        public IActionResult Create()
        {
            return View();
        }

        // HTTP POST VERSION  
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                Repository.Create(employee);
                return View("Thanks", employee);
            }
            else
                return View();
        }

        public IActionResult Update(string empname)
        {
            Employee employee = Repository.AllEmployees.Where(e => e.Name == empname).FirstOrDefault();
            return View(employee);
        }

        [HttpPost]
        public IActionResult Update(Employee employee, string empname)
        {
            if (ModelState.IsValid)
            {
                Repository.AllEmployees.Where(e => e.Name == empname).FirstOrDefault().Name = employee.Name;
                Repository.AllEmployees.Where(e => e.Name == empname).FirstOrDefault().Nationality = employee.Nationality;
                Repository.AllEmployees.Where(e => e.Name == empname).FirstOrDefault().DOB = employee.DOB;
                Repository.AllEmployees.Where(e => e.Name == empname).FirstOrDefault().Age = employee.Age;
                Repository.AllEmployees.Where(e => e.Name == empname).FirstOrDefault().Passport = employee.Passport;
                Repository.AllEmployees.Where(e => e.Name == empname).FirstOrDefault().Name = employee.Name;
                Repository.AllEmployees.Where(e => e.Name == empname).FirstOrDefault().QID = employee.QID;
                Repository.AllEmployees.Where(e => e.Name == empname).FirstOrDefault().Gender = employee.Gender;
                Repository.AllEmployees.Where(e => e.Name == empname).FirstOrDefault().MaritalStatus = employee.MaritalStatus;
                Repository.AllEmployees.Where(e => e.Name == empname).FirstOrDefault().JoiningDate = employee.JoiningDate;
                Repository.AllEmployees.Where(e => e.Name == empname).FirstOrDefault().Salary = employee.Salary;
                Repository.AllEmployees.Where(e => e.Name == empname).FirstOrDefault().Department = employee.Department;
                Repository.AllEmployees.Where(e => e.Name == empname).FirstOrDefault().Education = employee.Education;

                               
                return RedirectToAction("Index");
            }
            else
                return View();
        }

        [HttpPost]
        public IActionResult Delete(string empname)
        {
            Employee employee = Repository.AllEmployees.Where(e => e.Name == empname).FirstOrDefault();
            Repository.Delete(employee);
            return RedirectToAction("Index");
        }


    }
}