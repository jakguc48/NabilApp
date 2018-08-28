using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NabilApp.Models;

namespace NabilApp.Controllers
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
        [Route("Pracownicy")]
        public ActionResult Index()
        {
            var employee = GetEmployees();
            return View(employee);
        }


        [Route("Pracownicy/Szczegóły/{id:regex(\\d)}")]
        public ActionResult Details(int id)
        {
            var employee = GetEmployees().SingleOrDefault(c => c.Id == id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }


        private IEnumerable<Employee> GetEmployees()
        {
            return new List<Employee>
            {
                new Employee {Id = 1, LastName = "Rambo", FirstName = "John", Email = "JRambo@gmail.com", PhoneNumber = "791712322"},
                new Employee {Id = 2, LastName = "Slater",  FirstName = "Jack", Email = "JSlater@gmail.com", PhoneNumber = "984773661"}
            };
        }
    }
}
