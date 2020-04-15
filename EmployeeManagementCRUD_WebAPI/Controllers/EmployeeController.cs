using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Manager;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace EmployeeManagementCRUD_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        public readonly IEmployeeManger manager;
        public EmployeeController(IEmployeeManger manager)
        {
            this.manager = manager;
        }
        [Route("AddEmployee")]
        [HttpPost]
        public async Task<IActionResult> AddEmployee(Model.Employee employee)
        {
            var result = await this.manager.AddEmployee(employee);
            if (result == 1)
            {
                return this.Ok(employee);
            }
            else
            {
                return this.BadRequest();
            }
        }
        [Route("GetAllEmployee")]
        [HttpGet]
        public IEnumerable<Employee> GetAllEmployees()
        {
            return this.manager.GetAllEmployees();
        }
        [Route("UpdateEmployee")]
        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(Employee employeeChanges)
        {
            var result = await this.manager.UpdateEmployee(employeeChanges);
            if (result == 1)
            {
                return this.Ok(employeeChanges);
            }
            else
            {
                return this.BadRequest();
            }
        }
        [HttpDelete]
        [Route("DeleteEmployee")]
        public Employee DeleteEmployee(int id)
        {
            return this.manager.DeleteEmployee(id);
        }
        [Route("GetEmployee")]
        [HttpGet]
        public Employee GetEmployee(int id)
        {
            return this.manager.GetEmployee(id);
        }
        [Route("LoginEmployee")]
        [HttpPost]
        public IActionResult LoginEmployee(string email,string password)
        {
            var result = this.manager.LoginEmployee(email, password);
            if (result == true)
            {
                return this.Ok(email);
            }
            return this.BadRequest();
        }
    }
}