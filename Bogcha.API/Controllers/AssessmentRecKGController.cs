namespace Bogcha.API.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class AssessmentRecKGController : ControllerBase
{
    private readonly IAssessmentRecKGRepository repository;

    public AssessmentRecKGController(IAssessmentRecKGRepository repository)
    {
        this.repository = repository;
    }

    [HttpGet(Name = "assessment")]
    public async ValueTask<IActionResult> GetAllAssessmentRecKGAsync()
    {
        var res = await repository.GetAllAsync();
        return Ok(res);
    }
    [HttpGet(Name = "assesbyid")]
    public async ValueTask<IActionResult> GetAssessmentRecKGByIdAsync(int id)
    {
        var res = await repository.GetByIdAsync(id);
        return Ok(res);
    }
    [HttpPost(Name = "createassess")]
    public async ValueTask<IActionResult> CreateAssessmentRecKGAsync(AssessmentRecKG assessmentRecKG)
    {
        var res = await repository.CreateAsync(assessmentRecKG);
        return Ok(res);
    }
    [HttpPut(Name = "uptassess")]
    public async ValueTask<IActionResult> UpdateAssessmentRecKGAsync(int id, AssessmentRecKG assessmentRecKG)
    {
        var res = await repository.UpdateAsync(id, assessmentRecKG);
        return Ok(res);
    }
    [HttpDelete(Name = "delass")]
    public async ValueTask<IActionResult> DeleteAssessmentRecKGAsync(int id)
    {
        var res = await repository.DeleteAsync(id);
        return Ok(res);
    }
}
