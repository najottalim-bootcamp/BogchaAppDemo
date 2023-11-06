namespace Bogcha.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RevenueController : ControllerBase
    {
        private readonly IRevenueService revenueService;

        public RevenueController(IRevenueService revenueService)
        {
            this.revenueService = revenueService;
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetAllRevenuesAsync() 
        {
            var res =await revenueService.GetAllAsync();
            return Ok(res);
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetRevenueByIdAsync(string ChId) 
        {
            var res = await revenueService.GetByIdAsync(ChId);
            return Ok(res);
        }
        [HttpPost]
        public async ValueTask<IActionResult> CreateRevenueAsync(Revenue revenue)
        {
            var res = await revenueService.CreateAsync(revenue);
            return Ok(res);
        }
        [HttpPut]
        public async ValueTask<IActionResult> UpdateRevenueAsync(Revenue revenue)
        {
            var res = await revenueService.UpdateAsync(revenue);
            return Ok(res);
        }
        [HttpDelete]
        public async ValueTask<IActionResult> DeleteRevenueAsync(string ChId)
        {
            var res = await revenueService.DeleteAsync(ChId);
            return Ok(res);
        }
    }
}
