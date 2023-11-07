using Bogcha.Domain.Entities;
using Bogcha.Infrastructure.Services.BlackListServices;
using Bogcha.Infrastructure.Services.ImmunizationRecordServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bogcha.API.Controllers.ImmunizationRecordControllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class ImmunizationRecordController : ControllerBase
{
    private IImmunizationRecordService _immunizationRecord;

    public ImmunizationRecordController(IImmunizationRecordService immunizationRecord)
    {
        _immunizationRecord = immunizationRecord;
    }
    [HttpGet]
    public async ValueTask<IActionResult> GetAllStudentsAsync()
    {
        var res = await _immunizationRecord.GetAllAsync();
        return Ok(res);
    }
    [HttpGet]
    public async ValueTask<IActionResult> GetStudentByIdAsync(int Id)
    {
        var res = await _immunizationRecord.GetByIdAsync(Id);
        return Ok(res);
    }
    [HttpPost]
    public async ValueTask<IActionResult> CreateStudentAsync(ImmunizationRecord str)
    {
        var res = await _immunizationRecord.CreateAsync(str);
        return Ok(res);
    }
    [HttpPut]
    public async ValueTask<IActionResult> UpdateStudentAsync(ImmunizationRecord str)
    {
        var res = await _immunizationRecord.UpdateAsync(str);
        return Ok(res);
    }
    [HttpDelete]
    public async ValueTask<IActionResult> DeleteStudentAsync(int ChId)
    {
        var res = await _immunizationRecord.DeleteAsync(ChId);
        return Ok(res);
    }
}
