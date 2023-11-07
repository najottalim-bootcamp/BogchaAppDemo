using Bogcha.Infrastructure.Services.EmployeeServices.EmployeeDtos;

namespace Bogcha.API.Controllers.EmployeeControllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class EmployeeController : ControllerBase
{
    private IEmployeeService _employee;

    public EmployeeController(IEmployeeService employee)
    {
        _employee = employee;
    }


    public async ValueTask<IActionResult> GetAllEmployeeAsync()
    {
        IEnumerable<Employee> employee = await _employee.GetAllEmployeeAsync();

        return Ok(employee);
    }
    [HttpGet]
    public async ValueTask<IActionResult> GetEmployeeByIdAsync(string EmpId)
    {
        Employee employee = await _employee.GetEmployeeByIdAsync(EmpId);

        if (employee is null)
            return NotFound(EmpId);

        return Ok(employee);
    }
    [HttpPost]
    public async ValueTask<IActionResult> CreateAsync(CreateEmployeeDto createEmployeeDto)
    {
        bool result = await _employee.CreateAsync(createEmployeeDto);
        if (result)
        {
            return Created(Request.GetDisplayUrl(), createEmployeeDto);
        }
        return BadRequest(createEmployeeDto);
    }
    [HttpPut]
    public async ValueTask<IActionResult> UpdateAsync(string EmpId, UpdateEmployeeDto updateEmployeeDto)
    {
        bool result = await _employee.UpdateAsync(EmpId, updateEmployeeDto);

        if (result)
            return NoContent();
        return BadRequest(updateEmployeeDto);
    }
    [HttpDelete]
    public async ValueTask<IActionResult> DeleteAsync(string EmpId)
    {
        bool result = await _employee.DeleteAsync(EmpId);
        if (result)
            return NoContent();
        return BadRequest(result);
    }





}
