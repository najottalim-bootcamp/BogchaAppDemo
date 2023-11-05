namespace Bogcha.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealPlanController : ControllerBase
    {
        private readonly IMealPlanService mealPlanService;

        public MealPlanController(IMealPlanService mealPlanService)
        {
            this.mealPlanService = mealPlanService;
        }
    }
}
