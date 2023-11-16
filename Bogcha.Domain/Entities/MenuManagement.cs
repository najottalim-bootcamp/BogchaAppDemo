using System.ComponentModel.DataAnnotations.Schema;

namespace Bogcha.Domain.Entities;

public class MenuManagement
{
    public string ChId { get; set; }
    public string Monday { get; set; }
    public string Tuesday { get; set; }
    public string Wednesday { get; set; }
    public string Thursday { get; set; }
    public string Friday { get; set; }
    [ForeignKey(nameof(ChId))]
    public virtual Student Studnet { get; set; }
    [ForeignKey(nameof(Monday))]
    public virtual MealPlan MondayMeal { get; set; }
    [ForeignKey(nameof(Tuesday))]
    public virtual MealPlan TuesdayMeal { get; set; }
    [ForeignKey(nameof(Wednesday))]
    public virtual MealPlan WednesdayMeal { get; set; }
    [ForeignKey(nameof(Thursday))]
    public virtual MealPlan ThursdayMeal { get; set; }
}
