namespace Bogcha.Services.Services.MealPlanServices;

public class MealPlanService : IMealPlanService
{
    private readonly IMealPlanRepository mealPlanRepository;

    public MealPlanService(IMealPlanRepository mealPlanRepository)
    {
        this.mealPlanRepository = mealPlanRepository;
    }
    public async ValueTask<bool> CreateAsync(MealPlan mealPlan)
    {
        return await mealPlanRepository.CreateAsync(mealPlan);
    }

    public async ValueTask<bool> DeleteAsync(string MealNo)
    {
        return await mealPlanRepository.DeleteAsync(MealNo);
    }

    public ValueTask<IEnumerable<MealPlan>> GetAllAsync()
    {
        return mealPlanRepository.GetAllAsync();
    }

    public ValueTask<MealPlan> GetByIdAsync(string MealNo)
    {
        return mealPlanRepository.GetByIdAsync(MealNo);
    }

    public ValueTask<bool> UpdateAsync(MealPlan mealPlan)
    {
        return mealPlanRepository.UpdateAsync(mealPlan);
    }
}
