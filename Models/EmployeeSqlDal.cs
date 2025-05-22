using System.Collections.Generic;
using System.Linq;
using EFCore_CF_01.Models;

namespace EFCore_CF_01.DAL
{
    public class EmployeeSqlDAL : IEmployeeDAL
    {
        private readonly EmpDbcontext _context;

        public EmployeeSqlDAL(EmpDbcontext context)
        {
            _context = context;
        }

        // Create
        public void AddEmployee(Employee emp)
        {
            _context.Employees.Add(emp);
            _context.SaveChanges();
        }

        // Read All
        public List<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }

        // Read By ID
        public Employee GetEmployeeById(int id)
        {
            return _context.Employees.FirstOrDefault(e => e.Id == id);
        }

        // Update
        public void UpdateEmployee(Employee emp)
        {
            _context.Employees.Update(emp);
            _context.SaveChanges();
        }

        // Delete
        public void DeleteEmployee(int id)
        {
            var emp = _context.Employees.Find(id);
            if (emp != null)
            {
                _context.Employees.Remove(emp);
                _context.SaveChanges();
            }
        }

        public bool EmployeeExistsByName(string name)
        {
            return _context.Employees.Any(e => e.Name.ToLower() == name.ToLower());
        }
    }
}
