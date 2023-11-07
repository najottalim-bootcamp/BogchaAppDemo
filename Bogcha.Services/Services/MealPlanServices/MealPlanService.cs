namespace Bogcha.Infrastructure.Services.MealPlanServices;

public class MealPlanService : IMealPlanService
{
    private readonly IMealPlanRepository _mealPlanRepository;
    private readonly IMapper _mapper;

    public MealPlanService(IMealPlanRepository mealPlanRepository, IMapper mapper)
    {
        _mealPlanRepository = mealPlanRepository;
        _mapper = mapper;
    }
    public async ValueTask<MealPlan> GetMealPlanByIdAsync(string mealNo)
    {
        MealPlan? mealPlan = await _mealPlanRepository.GetByIdAsync(mealNo);
        return mealPlan;
    }
    public async ValueTask<IEnumerable<MealPlan>> GetAllMealPlansAsync()
    {
        IEnumerable<MealPlan> mealPlans = await _mealPlanRepository.GetAllAsync();
        return mealPlans;
    }
    public async ValueTask<bool> CreateMealPlanAsync(CreateMealPlanDto mealPlanDto)
    {
        MealPlan mealPlan = _mapper.Map<MealPlan>(mealPlanDto);
        bool result = await _mealPlanRepository.CreateAsync(mealPlan);
        return result;
    }
    public async ValueTask<bool> UpdateMealPlanAsync(string mealNo, UpdateMealPlanDto updateMealPlanDto)
    {
        MealPlan mealPlan = await _mealPlanRepository.GetByIdAsync(mealNo);
        if (mealPlan is null)
        {
            return false;
        }
        mealPlan = _mapper.Map<MealPlan>(updateMealPlanDto);
        mealPlan.MealNo = mealNo;

        bool result = await _mealPlanRepository.UpdateAsync(mealPlan);
        return result;
    }
    public async ValueTask<bool> DeleteMealPlanAsync(string mealNo)
    {
        bool result = await _mealPlanRepository.DeleteAsync(mealNo);
        return result;
    }
}
