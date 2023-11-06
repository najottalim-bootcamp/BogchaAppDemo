using Bogcha.DataAccess.Repositories.AssessmentRecPreKRepositories;

namespace Bogcha.API.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class AssessmentRecPreKController : ControllerBase
{
    private readonly IAssessmentRecPreKRepository assessmentRecPreKRepository;
    public AssessmentRecPreKController(IAssessmentRecPreKRepository assessmentRecPreKRepository)
    {
        this.assessmentRecPreKRepository = assessmentRecPreKRepository;        
    }
    [HttpGet]
    public async ValueTask<IActionResult> GetAllAssessmentRecPreKAsync()
    {
        var res = await assessmentRecPreKRepository.GetAllAsync();
        return Ok(res);
    }
    [HttpGet]
    public async ValueTask<IActionResult> GetAssessmentRecPreKByIdAsync(int id)
    {
        var res = await assessmentRecPreKRepository.GetByIdAsync(id);
        return Ok(res);
    }
    [HttpPost]
    public async ValueTask<IActionResult> CreateAssessmentRecPreKAsync(AssessmentRecPreK assessmentRecPreK)
    {
        var res = await assessmentRecPreKRepository.CreateAsync(assessmentRecPreK);
        return Ok(res);
    }
    [HttpPut]
    public async ValueTask<IActionResult> UpdateAssessmentRecPreKAsync(int id, AssessmentRecPreK assessmentRecPreK)
    {
        var res = await assessmentRecPreKRepository.UpdateAsync(id, assessmentRecPreK);
        return Ok(res);
    }
    [HttpDelete]
    public async ValueTask<IActionResult> DeleteAssessmentRecPreKAsync(int id)
    {
        var res = await assessmentRecPreKRepository.DeleteAsync(id);
        return Ok(res);
    }
}
