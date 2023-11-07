namespace Bogcha.Infrastructure.Services.AssessmentRecNurseryServices;

public class AssessmentRecNurseryService : IAssessmentRecNurseryService
{
    private readonly IAssessmentRecNurseryRepository assessmentRecNurseryRepository;
    public AssessmentRecNurseryService(IAssessmentRecNurseryRepository assessmentRecNurseryRepository)
    {
        this.assessmentRecNurseryRepository = assessmentRecNurseryRepository;
    }

    public ValueTask<bool> CreateAsync(AssessmentRecNursery assessmentRecKnursery)
    {
        return assessmentRecNurseryRepository.CreateAsync(assessmentRecKnursery);
    }

    public ValueTask<bool> DeleteAsync(int id)
    {
        return assessmentRecNurseryRepository.DeleteAsync(id);
    }

    public ValueTask<IEnumerable<AssessmentRecNursery>> GetAllAsync()
    {
        return assessmentRecNurseryRepository.GetAllAsync();
    }

    public ValueTask<AssessmentRecNursery> GetByIdAsync(int id)
    {
        return assessmentRecNurseryRepository.GetByIdAsync(id);
    }

    public ValueTask<bool> UpdateAsync(int id, AssessmentRecNursery assessmentRecnursery)
    {
        return assessmentRecNurseryRepository.UpdateAsync(id, assessmentRecnursery);
    }
}
