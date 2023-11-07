namespace Bogcha.API.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class MealPlanController : ControllerBase
{
    private readonly IMealPlanService _mealPlanService;

    public MealPlanController(IMealPlanService mealPlanService)
    {
        _mealPlanService = mealPlanService;
    }
    [HttpGet]
    public async ValueTask<IActionResult> GetAll()
    {
        IEnumerable<MealPlan> mealPlans =await _mealPlanService.GetAllMealPlansAsync();
        return Ok(mealPlans);
    }
    [HttpGet]
    public async ValueTask<IActionResult> GetAsync(string mealno)
    {
        MealPlan mealPlan = await _mealPlanService.GetMealPlanByIdAsync(mealno);
        if(mealPlan is null)
        {
            return NotFound();
        }
        return Ok(mealPlan);
    }
    [HttpPost]
    public async ValueTask<IActionResult> CreateAsync(CreateMealPlanDto mealPlan)
    {
        bool result = await _mealPlanService.CreateMealPlanAsync(mealPlan);
        if(result)
        {
            return Created(Request.GetDisplayUrl(), mealPlan);
        }
        return BadRequest(mealPlan);
    }
    [HttpPut]
    public async ValueTask<IActionResult> UpdateAsync(string mealNo, UpdateMealPlanDto mealPlan)
    {
        bool result = await _mealPlanService.UpdateMealPlanAsync(mealNo, mealPlan);
        if(result)
        {
            return NoContent();
        }
        return BadRequest(mealPlan);
    }
    [HttpDelete]
    public async ValueTask<IActionResult> DeleteAsync(string mealno)
    {
        bool result = await _mealPlanService.DeleteMealPlanAsync(mealno);
        if (result)
            return NoContent();
        return BadRequest(mealno);
    }

}
