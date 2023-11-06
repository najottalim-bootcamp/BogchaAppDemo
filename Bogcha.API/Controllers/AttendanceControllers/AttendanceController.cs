
namespace Bogcha.API.Controllers.AttendanceControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AttendanceController : ControllerBase
    {
        private readonly IAttendanceService _attendanceService;
        public AttendanceController(IAttendanceService context)
        {
            _attendanceService = context;
        }
        [HttpPost]
        public async ValueTask<IActionResult> GetAll()
        {
            return Ok(await _attendanceService.GetAllAsync());
        }
        [HttpPost]
        public async ValueTask<IActionResult> GetById(int id)
        {
            return Ok(await _attendanceService.GetByIdAsync(id));
        }
        [HttpPost]
        public async ValueTask<IActionResult> UpdateAsync(Attendance attendance)
        {
            return Ok(await _attendanceService.UpdateAsync(attendance));
        }
        [HttpPost]
        public async ValueTask<IActionResult> DeleteAsync(int id)
        {
            return Ok(await _attendanceService.DeleteAsync(id));
        }
        [HttpPost]
        public async ValueTask<IActionResult> CreateAsync(Attendance attendance)
        {
            return Ok(await _attendanceService.CreateAsync(attendance));
        }
    }
}
