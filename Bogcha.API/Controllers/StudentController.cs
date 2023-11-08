using Bogcha.Infrastructure.Services.StudentServices.StudensDtos;

namespace Bogcha.API.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class StudentController : ControllerBase
{
    private IStudentService _student;

    public StudentController(IStudentService student)
    {
        _student = student;
    }
    [HttpGet("GetAll")]
    public async ValueTask<IActionResult> GetAllStudentsAsync()
    {
        IEnumerable<Student> Studentss = await _student.GetAllStudentsAsync();

        return Ok(Studentss);
    }

    [HttpGet("GetById")]
    public async ValueTask<IActionResult> GetStudentsByIdAsync(string ChId)
    {
        Student student = await _student.GetStudentByIdAsync(ChId);

        if (student is null)
            return NotFound(ChId);

        return Ok(student);
    }
    [HttpPost]
    public async ValueTask<IActionResult> CreateAsync(CreateStudentsDto createStudentsDto)
    {
        bool result = await _student.CreateAsync(createStudentsDto);
        if (result)
        {
            return Created(Request.GetDisplayUrl(), createStudentsDto);
        }
        return BadRequest(createStudentsDto);
    }
    [HttpPut]
    public async ValueTask<IActionResult> UpdateAsync(string ChId, UpdateStudentsDto updateStudentsDto)
    {
        bool result = await _student.UpdateAsync(ChId, updateStudentsDto);

        if (result)
            return NoContent();
        return BadRequest(updateStudentsDto);
    }
    [HttpDelete]
    public async ValueTask<IActionResult> DeleteAsync(string ChId)
    {
        bool result = await _student.DeleteAsync(ChId);
        if (result)
            return NoContent();
        return BadRequest(result);
    }
}
