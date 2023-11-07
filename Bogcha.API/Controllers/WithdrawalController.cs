namespace Bogcha.API.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class WithdrawalController : ControllerBase
{
    private readonly IWithdrawalService _withdrawalService;

    public WithdrawalController(IWithdrawalService withdrawalService)
    {
        _withdrawalService = withdrawalService;
    }
    [HttpGet(Name ="GetAllWithdrawal")]
    public async ValueTask<IActionResult> GetAllWithdrawalsAsync()
    {
        IEnumerable<ViewWithdrawalDto> viewWithdrawalDtos = await _withdrawalService.GetAllAsync();
        return Ok(viewWithdrawalDtos);
    }

    [HttpGet(Name ="getbyidwith")]
    public async ValueTask<IActionResult> GetWithdrawalByIdAsync(int id)
    {
        ViewWithdrawalDto viewWithdrawalDto = await _withdrawalService.GetByIdAsync(id);
        if(viewWithdrawalDto is null) 
        {
            return BadRequest(id);
        }
        return Ok(viewWithdrawalDto);
    }

    [HttpPost(Name = "createWithDrawal")]
    public async ValueTask<IActionResult> CreateWithdrawalAsync(CreateWithdrawalDto createWithdrawal)
    {
        bool result = await _withdrawalService.CreateAsync(createWithdrawal);
        if (result)
            return Created(Request.GetDisplayUrl(), createWithdrawal);
        return BadRequest(createWithdrawal);
    }

    [HttpPut(Name = "updateWithDrawal")]
    public async ValueTask<IActionResult> UpdateWithdrawalAsync(int id, UpdateWithdrawalDto updateWithdrawal)
    {
        bool result = await _withdrawalService.UpdateAsync(id, updateWithdrawal);
        if (result)
            return NoContent();
        return BadRequest();
    }
    [HttpDelete(Name = "deleteWithDrawal")]
    public async ValueTask<IActionResult> DeleteWithdrawalAsync(int id)
    {
        bool result = await _withdrawalService.DeleteAsync(id);
        if (result)
            return NoContent();
        return BadRequest(result);
    }
}
