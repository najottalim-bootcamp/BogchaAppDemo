namespace Bogcha.API.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class MenuManagementController : ControllerBase
{
    private readonly IMenuManagementService menuManagementService;

    public MenuManagementController(IMenuManagementService menuManagementService)
    {
        this.menuManagementService = menuManagementService;
    }
    [HttpGet]
    public async ValueTask<IActionResult> Get()
    {
        var res = await menuManagementService.GetAllAsync();
        return Ok(res);
    }
    [HttpGet("{id}")]
    public async ValueTask<IActionResult> Get(string id)
    {
        var res = await menuManagementService.GetByIdAsync(id);
        return Ok(res);
    }
    [HttpPost]
    public async ValueTask<IActionResult> Post([FromBody] MenuManagement value)
    {
        var res = await menuManagementService.CreateAsync(value);
        return Ok(res);
    }
    [HttpPut("{id}")]
    public async ValueTask<IActionResult> Put([FromBody] MenuManagement value)
    {
        var res = await menuManagementService.UpdateAsync(value);
        return Ok(res);
    }
  //  [HttpDelete("{id}")]
/*    public async void Delete(string id)
    {
        var res = await menuManagementService.DeleteAsync(id);
        return Ok(res);
    }
*/
}
