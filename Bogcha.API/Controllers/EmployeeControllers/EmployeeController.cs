using Bogcha.Services.Services.EmployeeServices;
using Bogcha.Services.Services.RevenueServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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


  
    [HttpGet]
    public async ValueTask<IActionResult> GetAllEmployeesAsync()
    {
        var res = await _employee.GetAllAsync();
        return Ok(res);
    }
    [HttpGet]
    public async ValueTask<IActionResult> GetEmployeeByIdAsync(string ChId)
    {
        var res = await _employee.GetByIdAsync(ChId);
        return Ok(res);
    }
    [HttpPost]
    public async ValueTask<IActionResult> CreateRevenueAsync(Employee emp)
    {
        var res = await _employee.CreateAsync(emp);
        return Ok(res);
    }
    [HttpPut]
    public async ValueTask<IActionResult> UpdateRevenueAsync(Employee emp)
    {
        var res = await _employee.UpdateAsync(emp);
        return Ok(res);
    }
    [HttpDelete]
    public async ValueTask<IActionResult> DeleteEmployeeAsync(string ChId)
    {
        var res = await _employee.DeleteAsync(ChId);
        return Ok(res);
    }
}
