namespace Bogcha.Infrastructure.Services.ActivityManagementServices.ActivityManagemntDtos;
public class ViewActivityManagementDto
{
    public int Id { get; set; }
    public string Time { get; set; }
    public string Task { get; set; }
    public string Led_by { get; set; }
    
    [RegularExpression(@"^\+998\[0-9]{7}$", ErrorMessage = "phoneNumber must match the format '+998xx000xx00'")]
    public string phoneNO { get; set; }
    public string email { get; set; }
    public string empFName { get; set; }
    public string empLName { get; set; }

}
