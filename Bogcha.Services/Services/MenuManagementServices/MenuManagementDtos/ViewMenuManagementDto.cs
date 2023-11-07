namespace Bogcha.Infrastructure.Services.MenuManagementServices.MenuManagementDtos;
public class ViewMenuManagementDto
{
    public string ChId { get; set; }
    public string StudentFName { get; set; }
    public string StudentLName { get; set; }
    public string Monday { get; set; }
    public MealPlan MondayMealPlan { get; set; }
    public string Tuesday { get; set; }
    public MealPlan TuesdayMealPlan { get; set; }
    public string Wednesday { get; set; }
    public MealPlan WednesdayMealPlan { get; set; }
    public string Thursday { get; set; }
    public MealPlan ThursdayMealPlan { get; set; }
    public string Friday { get; set; }
    public MealPlan FridayMealPlan { get; set; }
}
