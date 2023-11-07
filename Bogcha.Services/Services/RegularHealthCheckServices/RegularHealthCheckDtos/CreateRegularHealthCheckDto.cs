namespace Bogcha.Infrastructure.Services.RegularHealthCheckServices.RegularHealthCheckDtos;
public class CreateRegularHealthCheckDto
{

    public string ChId { get; set; }
    public DateTime CheckupDate { get; set; }
    public string? Symptom { get; set; }
    public string? ActionRequired { get; set; }

}
