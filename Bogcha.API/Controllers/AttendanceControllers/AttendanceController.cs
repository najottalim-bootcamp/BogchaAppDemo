
using Bogcha.Infrastructure.Services.AttendanceServices.AttendanceDto;

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
        [HttpGet]
        public async ValueTask<IActionResult> GetAll()
        {
            return Ok(await _attendanceService.GetAllAsync());
        }
        [HttpGet("{id}")]
        public async ValueTask<IActionResult> GetById(int id)
        {
            return Ok(await _attendanceService.GetByIdAsync(id));
        }
        [HttpPut("{id}")]
        public async ValueTask<IActionResult> UpdateAsync(int id,UpdateAttendanceDto attendance)
        {
            return Ok(await _attendanceService.UpdateAsync(id,attendance));
        }
        [HttpDelete("{id}")]
        public async ValueTask<IActionResult> DeleteAsync(int id)
        {
            return Ok(await _attendanceService.DeleteAsync(id));
        }
        [HttpPost]
        public async ValueTask<IActionResult> CreateAsync(CreateAttendanceDto attendance)
        {
            return Ok(await _attendanceService.CreateAsync(attendance));
        }
    }
}
