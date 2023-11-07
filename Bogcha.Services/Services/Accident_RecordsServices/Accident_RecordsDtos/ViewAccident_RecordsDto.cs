namespace Bogcha.Infrastructure.Services.Accident_RecordsServices.Accident_RecordsDtos;
public class ViewAccident_RecordsDto
{
    public int AccNo { get; set; }

    [RegularExpression(@"^[A-Z]{2}[0-9]{3}$", ErrorMessage = "ChildId must match the format 'XX999'")]

    public string ChID { get; set; }
    public DateTime? AccidentDate { get; set; }
    public string TypeOfAccident { get; set; }
    public string Location { get; set; }
    public string FirstAid { get; set; }

    public string ChFName { get; set; }
    public string ChLName { get; set; }
}
