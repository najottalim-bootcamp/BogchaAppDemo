namespace Bogcha.API.Controllers.ParentsContollers;

[Route("api/[controller]/[action]")]
[ApiController]
public class ParentsController : ControllerBase
{
    private IParentsService _parents;

    public ParentsController(IParentsService parents)
    {
        _parents = parents;
    }
    [HttpGet]
    public async ValueTask<IActionResult> GetAllParentsAsync()
    {
        var res = await _parents.GetAllAsync();
        return Ok(res);
    }
    [HttpGet]
    public async ValueTask<IActionResult> GetParentsByIdAsync(string ChId)
    {
        var res = await _parents.GetByIdAsync(ChId);
        return Ok(res);
    }
    [HttpPost]
    public async ValueTask<IActionResult> CreateParentsAsync(Parents par)
    {
        var res = await _parents.CreateAsync(par);
        return Ok(res);
    }
    [HttpPut]
    public async ValueTask<IActionResult> UpdateParentsAsync(Parents par)
    {
        var res = await _parents.UpdateAsync(par);
        return Ok(res);
    }
    [HttpDelete]
    public async ValueTask<IActionResult> DeleteParentsAsync(string ChId)
    {
        var res = await _parents.DeleteAsync(ChId);
        return Ok(res);
    }
}
