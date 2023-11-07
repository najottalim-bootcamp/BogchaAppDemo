using Bogcha.Infrastructure.Services.ActivityManagementServices.ActivityManagemntDtos;

namespace Bogcha.API.Controllers.ActivityManagementControllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class ActivityManagementController : ControllerBase

{
    private readonly IActivityManagementService _activityManagement;
    public ActivityManagementController(IActivityManagementService context)
    {
        _activityManagement = context;
    }
    [HttpGet]
    public async ValueTask<IActionResult> GetAll()
    {
        return Ok(await _activityManagement.GetAllAsync());
    }
    [HttpGet("{id}")]
    public async ValueTask<IActionResult> GetById(int id)
    {
        return Ok(await _activityManagement.GetByIdAsync(id));
    }
    [HttpPut("{id}")]
    public async ValueTask<IActionResult> UpdateAsync(int id, UpdateActivityManagementDto activityManagement)
    {
        return Ok(await _activityManagement.UpdateAsync(id, activityManagement));
    }
    [HttpDelete("{id}")]
    public async ValueTask<IActionResult> DeleteAsync(int id)
    {
        return Ok(await _activityManagement.DeleteAsync(id));
    }
    [HttpPost]
    public async ValueTask<IActionResult> CreateAsync(CreateActivityManagementDto activityManagement)
    {
        return Ok(await _activityManagement.CreateAsync(activityManagement));

    }
}
