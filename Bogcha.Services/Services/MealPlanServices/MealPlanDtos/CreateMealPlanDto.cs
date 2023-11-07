namespace Bogcha.Infrastructure.Services.MealPlanServices.MealPlanDtos;
public class CreateMealPlanDto
{
    public string DateName { get; set; }
    [RegularExpression("^[A-Z]{2}[0-9]{2}$", ErrorMessage = "MealNo must match the format XX99")]
    public string MealNo { get; set; }
    public string AM_Snack { get; set; }
    public string Lunch { get; set; }
    public string Fruit { get; set; }
    public string PM_Snack { get; set; }
}
