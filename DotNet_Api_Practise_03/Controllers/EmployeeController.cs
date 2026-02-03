using DotNet_Api_Practise_03.Entities.Dtos;
using DotNet_Api_Practise_03.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNet_Api_Practise_03.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("All")]
        public async Task<ActionResult<List<GetAllEmployeesDto>>> GetAllEmployees()
        {
            var emp = await _employeeService.GetAllEmployees();
            return Ok(emp);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<GetEmployeeByIdDto?>> GetEmployeeById(int id)
        {
            var emp = await _employeeService.GetEmployeeById(id);
            if (emp is null)
                return BadRequest($"Employee with the ID:{id} not available!");
            return Ok(emp);
        }

        [HttpPost]
        public async Task<ActionResult<GetEmployeeByIdDto?>> CreateEmployee(CreateEmployeeDto create)
        {
            var emp = await _employeeService.CreateEmployee(create);

            return CreatedAtAction(nameof(CreateEmployee), new { id = emp.Id }, emp);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<bool>> UpdateEmployeeById(int id,UpdateEmployeeDto update)
        {
            var emp = await _employeeService.UpdateEmployee(id, update);
            if(emp == false)
                return BadRequest($"Employee with the ID:{id} not available!");
            return Ok(emp);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<bool>> DeleteEmployeeById(int id)
        {
            var emp =await _employeeService.DeleteEmployee(id);
            if(!emp)
                return BadRequest($"Employee with the ID:{id} not available!");
            return Ok(emp);
        }
    }
}
