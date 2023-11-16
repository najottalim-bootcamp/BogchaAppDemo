using System.ComponentModel.DataAnnotations.Schema;

namespace Bogcha.Domain.Entities;

public class MealPlan
{
    public MealPlan()
    {
        FridayManagements = new HashSet<MenuManagement>();
    }
    public string DateName { get; set; }
    public string MealNo { get; set; }
    public string AM_Snack { get; set; }
    public string Lunch { get; set; }
    public string Fruit { get; set; }
    public string PM_Snack { get; set; }

    public virtual List<MenuManagement> MondayManagements { get; set; }
   
    public virtual List<MenuManagement> TuesdayManagements { get; set; }
    
    public virtual List<MenuManagement> WednesdayManagements { get; set; }
    
    public virtual List<MenuManagement> ThursdayManagements { get; set; }
    
    public virtual ICollection<MenuManagement> FridayManagements { get; set; }
}
