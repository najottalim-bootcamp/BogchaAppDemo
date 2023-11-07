namespace Bogcha.Infrastructure.Services.MealPlanServices;

public interface IMealPlanService
{
    ValueTask<bool> CreateMealPlanAsync(CreateMealPlanDto mealPlanDto);
    ValueTask<bool> DeleteMealPlanAsync(string mealNo);
    ValueTask<IEnumerable<MealPlan>> GetAllMealPlansAsync();
    ValueTask<MealPlan> GetMealPlanByIdAsync(string mealNo);
    ValueTask<bool> UpdateMealPlanAsync(string mealNo, UpdateMealPlanDto updateMealPlanDto);
}