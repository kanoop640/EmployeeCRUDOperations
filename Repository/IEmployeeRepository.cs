using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IEmployeeRepository

    {
        Employee GetEmployee(int id);
        IEnumerable<Employee> GetAllEmployees();
        Task<int> AddEmployee(Employee employee);
        Task<int> UpdateEmployee(Employee employeeChanges);
        Employee DeleteEmployee(int id);
    }
}
