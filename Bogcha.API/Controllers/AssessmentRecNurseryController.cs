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
    [HttpGet(Name = "recnur")]
    public async ValueTask<IActionResult> GetAllAssessmentRecNurseryAsync()
    {
        var res = await assessmentRecNurseryRepository.GetAllAsync();
        return Ok(res);
    }
    [HttpGet(Name = "getrecnurass")]
    public async ValueTask<IActionResult> GetAssessmentRecNurseryByIdAsync(int id)
    {
        var res = await assessmentRecNurseryRepository.GetByIdAsync(id);
        return Ok(res);
    }
    [HttpPost(Name = "createnurass")]
    public async ValueTask<IActionResult> CreateAssessmentRecNurseryAsync(AssessmentRecNursery assessmentRecNursery)
    {
        var res = await assessmentRecNurseryRepository.CreateAsync(assessmentRecNursery);
        return Ok(res);
    }
    [HttpPut(Name = "updatenurass")]
    public async ValueTask<IActionResult> UpdateAssessmentRecKGAsync(int id, AssessmentRecNursery assessmentRecNursery)
    {
        var res = await assessmentRecNurseryRepository.UpdateAsync(id, assessmentRecNursery);
        return Ok(res);
    }
    [HttpDelete(Name = "delnur")]
    public async ValueTask<IActionResult> DeleteAssessmentRecKGAsync(int id)
    {
        var res = await assessmentRecNurseryRepository.DeleteAsync(id);
        return Ok(res);
    }
}
