namespace Bogcha.Infrastructure.Services.AssessmentRecPreKServices;

public class AssessmentRecPreKService : IAssessmentRecPreKService
{
    private readonly IAssessmentRecKGRepository assessmentRecKGRepository;
    public AssessmentRecPreKService(IAssessmentRecKGRepository assessmentRecKGRepository)
    {
        this.assessmentRecKGRepository = assessmentRecKGRepository;

    }

    public ValueTask<bool> CreateAsync(AssessmentRecKG assessmentRecKG)
    {
        return assessmentRecKGRepository.CreateAsync(assessmentRecKG);
    }

    public ValueTask<bool> DeleteAsync(int id)
    {
        return assessmentRecKGRepository.DeleteAsync(id);
    }

    public ValueTask<IEnumerable<AssessmentRecKG>> GetAllAsync()
    {
        return assessmentRecKGRepository.GetAllAsync();
    }

    public ValueTask<AssessmentRecKG> GetByIdAsync(int id)
    {
        return assessmentRecKGRepository.GetByIdAsync(id);
    }

    public ValueTask<bool> UpdateAsync(int id, AssessmentRecKG assessmentRecKG)
    {
        return assessmentRecKGRepository.UpdateAsync(id, assessmentRecKG);
    }
}
