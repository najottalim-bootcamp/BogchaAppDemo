namespace Bogcha.Infrastructure.Services.AttendanceServices.AttendanceDto;
public class CreateAttendanceDto
{
    public string ChId { get; set; }
    public DateTime? SignIn_Time { get; set; }
    public DateTime? SignOut_Time { get; set; }
}
