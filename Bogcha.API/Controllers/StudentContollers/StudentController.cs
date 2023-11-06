namespace Bogcha.API.Controllers.StudentContollers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentService _student;

        public StudentController(IStudentService student)
        {
            _student = student;
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetAllStudentsAsync()
        {
            var res = await _student.GetAllAsync();
            return Ok(res);
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetStudentByIdAsync(string CHId)
        {
            var res = await _student.GetByIdAsync(CHId);
            return Ok(res);
        }
        [HttpPost]
        public async ValueTask<IActionResult> CreateStudentAsync(Student str)
        {
            var res = await _student.CreateAsync(str);
            return Ok(res);
        }
        [HttpPut]
        public async ValueTask<IActionResult> UpdateStudentAsync(Student str)
        {
            var res = await _student.UpdateAsync(str);
            return Ok(res);
        }
        [HttpDelete]
        public async ValueTask<IActionResult> DeleteStudentAsync(string ChId)
        {
            var res = await _student.DeleteAsync(ChId);
            return Ok(res);
        }
    }



}
