using Examplee.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Examplee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
       public AttendenceSystemContext db=new AttendenceSystemContext();
        public EmployeeController()
        {
        //    employee.Add(new Employee() { EmpId = 1, Name = "Anu" });
        //    employee.Add(new Employee() { EmpId = 2, Name = "Balu" });
        //    employee.Add(new Employee() { EmpId = 3, Name = "Charan" });
        }
        [HttpGet]
        public IEnumerable<Employee> GetEmployees()
        {
            return db.Employees;
        }
        
        [HttpPost]
        public string AddEmployee(Employee emp)
        {
            db.Employees.Add(emp);
            return emp.EmpName;
        }

        [HttpPut]
        public string UpdateEmployee(int empId, Employee emp)
        {
            var foundEmp =db.Employees.Find(empId);
            db.Employees.Update(emp);
            return empId.ToString();
        }


    }
}
