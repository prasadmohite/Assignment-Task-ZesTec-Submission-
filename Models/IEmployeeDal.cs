using System.Collections.Generic;

namespace EFCore_CF_01.Models
{
    public interface IEmployeeDAL
    {
        void AddEmployee(Employee emp);

        List<Employee> GetAllEmployees();


        Employee GetEmployeeById(int id);

        
        void UpdateEmployee(Employee emp);

        void DeleteEmployee(int id);

        bool EmployeeExistsByName(string name);

    }
}
