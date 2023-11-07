using Bogcha.Infrastructure.Services.Accident_RecordsServices.Accident_RecordsDtos;

namespace Bogcha.API.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class Accident_RecordsController : ControllerBase
{
    private readonly IAccident_RecordsService _accident_records_service;
    public Accident_RecordsController(IAccident_RecordsService context) { _accident_records_service = context; }

    [HttpGet]
    public async ValueTask<IActionResult> GetAllAsync()
    {
        var d = await _accident_records_service.GetAllAsync();
        return Ok(d);
    }
    [HttpPost]
    public async ValueTask<IActionResult> CreateAsync(CreateAccident_RecordsDto accident_Records)
    {
        var d = await _accident_records_service.CreateAsync(accident_Records);
        return Ok(d);
    }
    [HttpPut("{id}")]
    public async ValueTask<IActionResult> UpdateAsync(int id, UpdateAccident_RecordsDto accident_Records)
    {
        var d = await _accident_records_service.UpdateAsync(id, accident_Records);
        return Ok(d);
    }
    [HttpGet("{id}")]
    public async ValueTask<IActionResult> GetByIdAsync(int id)
    {
        var d = await _accident_records_service.GetByIdAsync(id);
        return Ok(d);
    }
    [HttpDelete("{id}")]
    public async ValueTask<IActionResult> DeleteByIdAsync(int id)
    {
        var d = await _accident_records_service.DeleteAsync(id);
        return Ok(d);
    }

}
