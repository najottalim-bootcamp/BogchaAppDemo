
namespace Bogcha.Infrastructure.Services.AttendanceServices
{
    public interface IAttendanceService 
    {

        public ValueTask<bool> CreateAsync(CreateAttendanceDto attendance);
        public ValueTask<bool> UpdateAsync(int id,UpdateAttendanceDto UpdateAttendance);
        public ValueTask<bool> DeleteAsync(int id);
        public ValueTask<ViewAttendanceDto> GetByIdAsync(int id);
        public ValueTask<IEnumerable<ViewAttendanceDto>> GetAllAsync();
    }
}
