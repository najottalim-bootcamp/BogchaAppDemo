namespace Bogcha.DataAccess.Repositories.AttendanceRepositories;

public interface IAttendanceRepository
{
    public ValueTask<bool> CreateAsync(Attendance attendance);
    public ValueTask<bool> UpdateAsync(Attendance attendance);
    public ValueTask<bool> DeleteAsync(int id);
    public ValueTask<Attendance> GetByIdAsync(int id);
    public ValueTask<IEnumerable<Attendance>> GetAllAsync();
}
