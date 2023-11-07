namespace Bogcha.Infrastructure.Services.RegularHealthCheckServices.RegularHealthCheckDtos;
public class ViewRegularHealthCheckDto
{

    public int Id { get; set; }
    public string ChId { get; set; }
    public DateTime CheckupDate { get; set; }
    public string? Symptom { get; set; }
    public string? ActionRequired { get; set; }
    
    public string ChLName { get; set; }
    public string ChFName { get; set;}
    public string gender { get; set; }
    public string AllergyType { get; set; }
    public string AllergySymptom { get; set; }
}
