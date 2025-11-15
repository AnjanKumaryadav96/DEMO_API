using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DEMO_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        // Define Employee model
        public class Employee
        {
            public string Name { get; set; }
            public string Designation { get; set; }
        }

        // GET: api/home
        [HttpGet]
        public ActionResult<List<Employee>> Get()
        {
            List<Employee> emp = new List<Employee>
            {
                new Employee { Name = "Anjan Kumar Yadav Bandagorla", Designation = "Software Engineer" },
                new Employee { Name = "Anusha Yadav BG", Designation = "UI Developer" },
                new Employee { Name = "Shreyas Yadav Bandagorla", Designation = "QA Analyst" },
                new Employee { Name = "Rahul", Designation = "Project Manager" },
                new Employee { Name = "Sneha", Designation = "HR Executive" },
                new Employee { Name = "Vikram", Designation = "DevOps Engineer" },
                new Employee { Name = "Kavya", Designation = "Business Analyst" },
                new Employee { Name = "Tejas", Designation = "Backend Developer" },
                new Employee { Name = "Priya", Designation = "Frontend Engineer" },
                new Employee { Name = "Manoj", Designation = "Cloud Architect" }
            };

            return Ok(emp);
        }
    }
}
