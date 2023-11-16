namespace Bogcha.Domain.Entities;

public class Attendance
{
    public int Id { get; set; }
    public string ChId { get; set; }
    public DateTime? SignIn_Time { get; set; }
    public DateTime? SignOut_Time { get; set; }

    public virtual Student Studnet { get; set; }

}
