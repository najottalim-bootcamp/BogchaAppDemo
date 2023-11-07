namespace Bogcha.Infrastructure.Services.Accident_RecordsServices.Accident_RecordsDtos;
public class UpdateAccident_RecordsDto
{

    [RegularExpression(@"^[A-Z]{2}[0-9]{3}$", ErrorMessage = "ChId must match the format 'XX999'")]
    public string ChID { get; set; }
    public DateTime AccidentDate { get; set; }
    public string TypeOfAccident { get; set; }
    public string Location { get; set; }
    public string FirstAid { get; set; }
}
