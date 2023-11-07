namespace Bogcha.API.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class RevenueController : ControllerBase
{
    private readonly IRevenueService _revenueService;

    public RevenueController(IRevenueService revenueService)
    {
        _revenueService = revenueService;
    }
    [HttpGet]
    public async ValueTask<IActionResult> GetAllRevenuesAsync()
    {
        IEnumerable<ViewRevenueDto> viewRevenues = await _revenueService.GetAllRevenuesAsync();

        return Ok(viewRevenues);
    }
    [HttpGet]
    public async ValueTask<IActionResult> GetRevenueByIdAsync(string ChId)
    {
        ViewRevenueDto viewRevenue = await _revenueService.GetRevenueByIdAsync(ChId);

        if (viewRevenue is null)
            return NotFound(ChId);

        return Ok(viewRevenue);
    }
    [HttpPost]
    public async ValueTask<IActionResult> CreateRevenueAsync(CreateRevenueDto revenue)
    {
        bool result = await _revenueService.CreateAsync(revenue);
        if (result)
        {
            return Created(Request.GetDisplayUrl(), revenue);
        }
        return BadRequest(revenue);
    }
    [HttpPut]
    public async ValueTask<IActionResult> UpdateRevenueAsync(string chId, UpdateRevenueDto revenue)
    {
        bool result = await _revenueService.UpdateAsync(chId, revenue);

        if(result)
            return NoContent();
        return BadRequest(revenue);
    }
    [HttpDelete]
    public async ValueTask<IActionResult> DeleteRevenueAsync(string ChId)
    {
        bool result = await _revenueService.DeleteAsync(ChId);
        if(result)
            return NoContent();
        return BadRequest(result);
    }
}
