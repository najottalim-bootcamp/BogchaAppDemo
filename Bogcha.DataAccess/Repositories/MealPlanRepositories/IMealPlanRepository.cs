namespace Bogcha.DataAccess.Repositories.MealPlanRepositories;

public interface IMealPlanRepository
{
    public ValueTask<bool> CreateAsync(MealPlan mealPlan);
    public ValueTask<bool> UpdateAsync(MealPlan mealPlan);
    public ValueTask<bool> DeleteAsync(string MealNo);
    public ValueTask<MealPlan> GetByIdAsync(string MealNo);
    public ValueTask<IEnumerable<MealPlan>> GetAllAsync();
}
