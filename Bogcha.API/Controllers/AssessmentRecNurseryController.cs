namespace Bogcha.API.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class AssessmentRecNurseryController : ControllerBase
{
    private readonly IAssessmentRecNurseryRepository assessmentRecNurseryRepository;
    public AssessmentRecNurseryController(IAssessmentRecNurseryRepository assessmentRecNurseryRepository)
    {
        this.assessmentRecNurseryRepository = assessmentRecNurseryRepository;

    }
    [HttpGet]
    public async ValueTask<IActionResult> GetAllAssessmentRecNurseryAsync()
    {
        var res = await assessmentRecNurseryRepository.GetAllAsync();
        return Ok(res);
    }
    [HttpGet]
    public async ValueTask<IActionResult> GetAssessmentRecNurseryByIdAsync(int id)
    {
        var res = await assessmentRecNurseryRepository.GetByIdAsync(id);
        return Ok(res);
    }
    [HttpPost]
    public async ValueTask<IActionResult> CreateAssessmentRecNurseryAsync(AssessmentRecNursery assessmentRecNursery)
    {
        var res = await assessmentRecNurseryRepository.CreateAsync(assessmentRecNursery);
        return Ok(res);
    }
    [HttpPut]
    public async ValueTask<IActionResult> UpdateAssessmentRecKGAsync(int id, AssessmentRecNursery assessmentRecNursery)
    {
        var res = await assessmentRecNurseryRepository.UpdateAsync(id, assessmentRecNursery);
        return Ok(res);
    }
    [HttpDelete]
    public async ValueTask<IActionResult> DeleteAssessmentRecKGAsync(int id)
    {
        var res = await assessmentRecNurseryRepository.DeleteAsync(id);
        return Ok(res);
    }
}
