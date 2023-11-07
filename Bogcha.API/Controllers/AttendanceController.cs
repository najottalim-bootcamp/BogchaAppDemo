
using Bogcha.Infrastructure.Services.AttendanceServices.AttendanceDto;

namespace Bogcha.API.Controllers
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
        [HttpGet(Name = "getattendance")]
        public async ValueTask<IActionResult> GetAll()
        {
            return Ok(await _attendanceService.GetAllAsync());
        }
        [HttpGet(Name = "getbyidattendance")]
        public async ValueTask<IActionResult> GetById(int id)
        {
            return Ok(await _attendanceService.GetByIdAsync(id));
        }
        [HttpPut(Name = "putattendance")]
        public async ValueTask<IActionResult> UpdateAsync(int id, UpdateAttendanceDto attendance)
        {
            return Ok(await _attendanceService.UpdateAsync(id, attendance));
        }
        [HttpDelete(Name = "delattendance")]
        public async ValueTask<IActionResult> DeleteAsync(int id)
        {
            return Ok(await _attendanceService.DeleteAsync(id));
        }
        [HttpPost(Name = "ishla")]
        public async ValueTask<IActionResult> CreateAsync(CreateAttendanceDto attendance)
        {
            return Ok(await _attendanceService.CreateAsync(attendance));
        }
    }
}
