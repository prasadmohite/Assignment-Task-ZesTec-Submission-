using Microsoft.AspNetCore.Mvc;
using EFCore_CF_01.DAL;
using EFCore_CF_01.Models;
using Microsoft.AspNetCore.Authorization;

namespace EFCore_CF_01.Controllers
{
    
    public class EmployeeController : Controller
    {
        private readonly IEmployeeDAL _employeeDal;

        public EmployeeController(IEmployeeDAL employeeDal)
        {
            _employeeDal = employeeDal;
        }

        
        public IActionResult Index()
        {
            var employees = _employeeDal.GetAllEmployees();
            return View(employees);
        }

        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee emp)
        {
            if (_employeeDal.EmployeeExistsByName(emp.Name))
            {
                ModelState.AddModelError("Name", "An employee with this name already exists.");
            }

            if (ModelState.IsValid)
            {
                _employeeDal.AddEmployee(emp);
                return RedirectToAction("Index");
            }

            return View(emp);
        }



        [Authorize]
        public IActionResult Details(int id)
        {
            var emp = _employeeDal.GetEmployeeById(id);
            if (emp == null)
            {
                return NotFound();
            }
            return View(emp);
        }

        [Authorize]
        public IActionResult Edit(int id)
        {
            var emp = _employeeDal.GetEmployeeById(id);
            if (emp == null)
            {
                return NotFound();
            }
            return View(emp);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Employee emp)
        {
            if (ModelState.IsValid)
            {
                _employeeDal.UpdateEmployee(emp);
                return RedirectToAction("Index");
            }
            return View(emp);
        }

        [Authorize]
        public IActionResult Delete(int id)
        {
            var emp = _employeeDal.GetEmployeeById(id);
            if (emp == null)
            {
                return NotFound();
            }
            return View(emp);
        }

        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _employeeDal.DeleteEmployee(id);
            return RedirectToAction("Index");
        }
    }
}
