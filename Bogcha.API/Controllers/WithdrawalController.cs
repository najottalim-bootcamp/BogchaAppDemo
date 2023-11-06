namespace Bogcha.API.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class WithdrawalController : ControllerBase
{
    private readonly IWithdrawalService withdrawalService;

    public WithdrawalController(IWithdrawalService withdrawalService)
    {
        this.withdrawalService = withdrawalService;
    }
    [HttpGet]
    public async ValueTask<IActionResult> Get()
    {
        var res = await withdrawalService.GetAllAsync();
        return Ok(res);
    }

    [HttpGet("{id}")]
    public async ValueTask<IActionResult> Get(int id)
    {
        var res = await withdrawalService.GetByIdAsync(id);
        return Ok(res);
    }

    [HttpPost]
    public async ValueTask<bool> Post([FromBody] Withdrawal withdrawal)
    {
        return await withdrawalService.CreateAsync(withdrawal);
    }

    [HttpPut("{id}")]
    public async ValueTask<bool> Put(int id, [FromBody] Withdrawal withdrawal)
    {
        return await withdrawalService.UpdateAsync(withdrawal);
    }
    [HttpDelete("{id}")]
    public async ValueTask<bool> Delete(int id)
    {
        return await withdrawalService.DeleteAsync(id);
    }
}
