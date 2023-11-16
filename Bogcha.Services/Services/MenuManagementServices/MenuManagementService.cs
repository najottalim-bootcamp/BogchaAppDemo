namespace Bogcha.Infrastructure.Services.MenuManagementServices;

public class MenuManagementService : IMenuManagementService
{
    private readonly IMenuManagementRepository _menuManagementRepository;
    private readonly IMealPlanRepository _mealPlanRepository;
    private readonly IStudentRepository _studentRepository;
    private readonly IMapper _mapper;

    public MenuManagementService(
        IMenuManagementRepository menuManagementRepository,
        IMealPlanRepository mealPlanRepository,
        IStudentRepository studentRepository,
        IMapper mapper)
    {
        _menuManagementRepository = menuManagementRepository;
        _mealPlanRepository = mealPlanRepository;
        _studentRepository = studentRepository;
        _mapper = mapper;
    }
    public async ValueTask<IEnumerable<ViewMenuManagementDto>> GetAllMenusAsync()
    {
        IEnumerable<MenuManagement> menuList = await _menuManagementRepository.GetAllAsync();
        IEnumerable<MealPlan> mealPlans = await _mealPlanRepository.GetAllAsync();
        IEnumerable<Student> students = await _studentRepository.GetAllAsync();

        IEnumerable<ViewMenuManagementDto> viewMenuManagements = menuList
            .GroupJoin(mealPlans, menu => menu.Monday, mealPlan => mealPlan.MealNo, (menu, mondayMealPlan) => new { menu, mondayMealPlan })
            .GroupJoin(mealPlans, temp => temp.menu.Tuesday, mealPlan => mealPlan.MealNo, (temp, tuesdayMealPlan) => new { temp.menu, temp.mondayMealPlan, tuesdayMealPlan })
            .GroupJoin(mealPlans, temp => temp.menu.Wednesday, mealPlan => mealPlan.MealNo, (temp, wednesdayMealPlan) => new { temp.menu, temp.mondayMealPlan, temp.tuesdayMealPlan, wednesdayMealPlan })
            .GroupJoin(mealPlans, temp => temp.menu.Thursday, mealPlan => mealPlan.MealNo, (temp, thursdayMealPlan) => new { temp.menu, temp.mondayMealPlan, temp.tuesdayMealPlan, temp.wednesdayMealPlan, thursdayMealPlan })
            .GroupJoin(mealPlans, temp => temp.menu.FridayId, mealPlan => mealPlan.MealNo, (temp, fridayMealPlan) => new { temp.menu, temp.mondayMealPlan, temp.tuesdayMealPlan, temp.wednesdayMealPlan, temp.thursdayMealPlan, fridayMealPlan })
            .Join(students, temp => temp.menu.ChId, student => student.CHId, (temp, std) => new ViewMenuManagementDto

            {
                ChId = temp.menu.ChId,
                StudentFName = std.ChFName,
                StudentLName = std.ChLName,
                Monday = temp.menu.Monday,
                MondayMealPlan = temp.mondayMealPlan.FirstOrDefault(),
                Tuesday = temp.menu.Tuesday,
                TuesdayMealPlan = temp.tuesdayMealPlan.FirstOrDefault(),
                Wednesday = temp.menu.Wednesday,
                WednesdayMealPlan = temp.wednesdayMealPlan.FirstOrDefault(),
                Thursday = temp.menu.Thursday,
                ThursdayMealPlan = temp.thursdayMealPlan.FirstOrDefault(),
                Friday = temp.menu.FridayId,
                FridayMealPlan = temp.fridayMealPlan.FirstOrDefault()
            });
        return viewMenuManagements;
    }
    public async ValueTask<ViewMenuManagementDto> GetMenuManagementByIdAsync(string chId)
    {
        MenuManagement menu = await _menuManagementRepository.GetByIdAsync(chId);
        if (menu is null)
            return null;

        IEnumerable<MealPlan> mealPlans = await _mealPlanRepository.GetAllAsync();
        Student student = await _studentRepository.GetByIdAsync(chId);

        ViewMenuManagementDto menuManagementDto = new ViewMenuManagementDto()
        {
            ChId = chId,
            StudentFName = student.ChFName,
            StudentLName = student.ChLName,
            Monday = menu.Monday,
            MondayMealPlan = mealPlans.FirstOrDefault(x => x.MealNo == menu.Monday),
            Tuesday = menu.Tuesday,
            TuesdayMealPlan = mealPlans.FirstOrDefault(x => x.MealNo == menu.Tuesday),
            Wednesday = menu.Wednesday,
            WednesdayMealPlan = mealPlans.FirstOrDefault(x => x.MealNo == menu.Wednesday),
            Thursday = menu.Thursday,
            ThursdayMealPlan = mealPlans.FirstOrDefault(x => x.MealNo == menu.Thursday),
            Friday = menu.FridayId,
            FridayMealPlan = mealPlans.FirstOrDefault(x => x.MealNo == menu.FridayId),
        };
        return menuManagementDto;
    }
    public async ValueTask<bool> UpdateMenuManagementAsync(string chId, UpdateMenuManagementDto updateMenuDto)
    {
        MenuManagement menuManagement = _mapper.Map<MenuManagement>(updateMenuDto);
        menuManagement.ChId = chId;

        bool result = await _menuManagementRepository.UpdateAsync(menuManagement);
        return result;
    }
    public async ValueTask<bool> CreateMenuManagement(CreateMenuManagementDto createMenuManagementDto)
    {
        MenuManagement menu = _mapper.Map<MenuManagement>(createMenuManagementDto);

        bool result = await _menuManagementRepository.CreateAsync(menu);
        return result;
    }
    public async ValueTask<bool> DeleteMenuManagementAsync(string chId)
    {
        MenuManagement menu = await _menuManagementRepository.GetByIdAsync(chId);
        if (menu is null)
        {
            return false;
        }
        bool result = await _menuManagementRepository.DeleteAsync(chId);
        return result;
    }
}
