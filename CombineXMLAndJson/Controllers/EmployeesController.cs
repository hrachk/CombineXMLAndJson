using CombineXMLAndJson.Models;
using Microsoft.AspNetCore.Mvc;

namespace CombineXMLAndJson.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        [HttpGet("get.{format}"), FormatFilter]
        public IEnumerable<Employee> Get()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Sarath Lal", City="Cochin" },
                new Employee { Id = 2, Name = "Anil Kumar", City="Bangalore"}
            };
            return employees;
        }

        [HttpPost("post.{format}"), FormatFilter]
        public Employee Post([FromBody] Employee employee)
        {
            if (ModelState.IsValid)
            {
                return employee;
            }
            else
            {
                return null;
            }
        }
    }
}
