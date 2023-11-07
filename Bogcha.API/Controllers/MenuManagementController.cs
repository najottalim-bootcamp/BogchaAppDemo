
namespace Bogcha.API.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class MenuManagementController : ControllerBase
{
    private readonly IMenuManagementService _menuManagementService;

    public MenuManagementController(IMenuManagementService menuManagementService)
    {
        _menuManagementService = menuManagementService;
    }
    [HttpGet]
    public async ValueTask<IActionResult> GetAllMenuManagementAsync()
    {
        IEnumerable<ViewMenuManagementDto> menuManagementDtos = await _menuManagementService.GetAllMenusAsync();
        return Ok(menuManagementDtos);
    }
    [HttpGet("{id}")]
    public async ValueTask<IActionResult> GetMenuManagementById(string id)
    {
        ViewMenuManagementDto menuManagementDto = await _menuManagementService.GetMenuManagementByIdAsync(id);
        if(menuManagementDto is null)
        {
            return BadRequest(id);
        }
        return Ok(menuManagementDto);
    }
    [HttpPost]
    public async ValueTask<IActionResult> CreateMenuManagementAsync(CreateMenuManagementDto createMenuManagement)
    {
        bool result = await _menuManagementService.CreateMenuManagement(createMenuManagement);
        if(result)
        {
            return Created(Request.GetDisplayUrl(), createMenuManagement);
        }
        return BadRequest();
    }
    [HttpPut("{id}")]
    public async ValueTask<IActionResult> UpdateMenuManagementAsync(string id, UpdateMenuManagementDto updateMenu)
    {
        bool result = await _menuManagementService.UpdateMenuManagementAsync(id, updateMenu);
        if( result)
        {
            return Ok(updateMenu);
        }
        return BadRequest();
    }
    [HttpDelete("{id}")]
    public async ValueTask<IActionResult> DeleteMenuManagementAsync(string id)
    {
        bool result = await _menuManagementService.DeleteMenuManagementAsync(id);
        if(result)
            return Ok(result);
        return BadRequest();
    }

}
