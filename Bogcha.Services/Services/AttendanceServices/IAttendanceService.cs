namespace Bogcha.Infrastructure.Services.AttendanceServices
{
    public interface IAttendanceService 
    {

        public ValueTask<bool> CreateAsync(Attendance attendance);
        public ValueTask<bool> UpdateAsync(Attendance attendance);
        public ValueTask<bool> DeleteAsync(int id);
        public ValueTask<Attendance> GetByIdAsync(int id);
        public ValueTask<IEnumerable<Attendance>> GetAllAsync();
    }
}
