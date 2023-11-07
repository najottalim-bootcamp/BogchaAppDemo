namespace Bogcha.Infrastructure.Services.AttendanceServices
{
    public class AttendanceService : IAttendanceService
    {
        private readonly IAttendanceRepository _attendanceService;
        public AttendanceService(IAttendanceRepository context) { _attendanceService = context; }
        public async ValueTask<bool> CreateAsync(Attendance attendance)
        {
            return await _attendanceService.CreateAsync(attendance);
        }

        public async ValueTask<bool> DeleteAsync(int id)
        {
            return await _attendanceService.DeleteAsync(id);
        }

        public async ValueTask<IEnumerable<Attendance>> GetAllAsync()
        {
            return await _attendanceService.GetAllAsync();
        }

        public async ValueTask<Attendance> GetByIdAsync(int id)
        {
            return await _attendanceService.GetByIdAsync(id);
        }

        public async ValueTask<bool> UpdateAsync(Attendance attendance)
        {
            return await _attendanceService.UpdateAsync(attendance);
        }
    }
}
