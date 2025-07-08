using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace portfolioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        [HttpPost("PostFormData")]
        public IActionResult PostFormData(Employee employee)
        {
            string filePath = "App_Data/employeeData.txt"; // Adjust path as needed

            if (!Directory.Exists("App_Data"))
            {
                Directory.CreateDirectory("App_Data");
            }

            var line = $"{employee.Name}|{employee.Email}|{employee.Mobile}";
            System.IO.File.AppendAllLines(filePath, new[] { line });

            return Ok("Employee data saved successfully.");
        }


    }
    public class Employee
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Mobile { get; set; }
    }

}
