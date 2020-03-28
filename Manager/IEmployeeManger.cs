using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    public interface IEmployeeManger
    {
        Employee GetEmployee(int id);
        IEnumerable<Employee> GetAllEmployees();
        Task<int> AddEmployee(Employee employee);
        Task<int> UpdateEmployee(Employee employeeChanges);
        Employee DeleteEmployee(int id);
    }
}
