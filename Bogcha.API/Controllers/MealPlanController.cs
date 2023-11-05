namespace Bogcha.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MealPlanController : ControllerBase
    {
        private readonly IMealPlanService mealPlanService;

        public MealPlanController(IMealPlanService mealPlanService)
        {
            this.mealPlanService = mealPlanService;
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetAll()
        {
            var res =await mealPlanService.GetAllAsync();
            return Ok(res);
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetAsync(string mealno)
        {
            var res = await mealPlanService.GetByIdAsync(mealno);
            return Ok(res);
        }
        [HttpPost]
        public async ValueTask<IActionResult> CreateAsync(MealPlan mealPlan)
        {
            var res = await mealPlanService.CreateAsync(mealPlan);
            return Ok(res);
        }
        [HttpPut]
        public async ValueTask<IActionResult> UpdateAsync(MealPlan mealPlan)
        {
            var res = await mealPlanService.UpdateAsync(mealPlan);
            return Ok(res);
        }
        [HttpDelete]
        public async ValueTask<IActionResult> DeleteAsync(string mealno)
        {
            var res = await mealPlanService.DeleteAsync(mealno);
            return Ok(res);
        }
    }
}
