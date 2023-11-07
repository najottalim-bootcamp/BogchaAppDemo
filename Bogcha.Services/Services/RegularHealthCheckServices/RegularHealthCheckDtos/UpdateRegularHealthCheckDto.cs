namespace Bogcha.Infrastructure.Services.RegularHealthCheckServices.RegularHealthCheckDtos;
public class UpdateRegularHealthCheckDto
{

    public DateTime CheckupDate { get; set; }
    public string? Symptom { get; set; }
    public string? ActionRequired { get; set; }

}
