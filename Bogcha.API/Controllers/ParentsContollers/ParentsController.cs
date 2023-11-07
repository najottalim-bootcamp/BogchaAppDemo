using Bogcha.Infrastructure.Services.ParentsServices.ParentsDtos;

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
    public async ValueTask<IActionResult> GetAllParentsAsync()
    {
        IEnumerable<ViewParentDto> viewParentDtos = await _parents.GetAllParentsAsync();

        return Ok(viewParentDtos);
    }
    [HttpGet]
    public async ValueTask<IActionResult> GetParentsByIdAsync(string ChId)
    {
        ViewParentDto viewParentDtos = await _parents.GetParentsByIdAsync(ChId);

        if (viewParentDtos is null)
            return NotFound(ChId);

        return Ok(viewParentDtos);
    }
    [HttpPost]
    public async ValueTask<IActionResult> CreateAsync(CreateParentsDto createParentsDto)
    {
        bool result = await _parents.CreateAsync(createParentsDto);
        if (result)
        {
            return Created(Request.GetDisplayUrl(), createParentsDto);
        }
        return BadRequest(createParentsDto);
    }
    [HttpPut]
    public async ValueTask<IActionResult> UpdateAsync(string chId, UpdateParentsDto updateParentsDto)
    {
        bool result = await _parents.UpdateAsync(chId, updateParentsDto);

        if (result)
            return NoContent();
        return BadRequest(updateParentsDto);
    }
    [HttpDelete]
    public async ValueTask<IActionResult> DeleteAsync(string ChId)
    {
        bool result = await _parents.DeleteAsync(ChId);
        if (result)
            return NoContent();
        return BadRequest(result);
    }
}
