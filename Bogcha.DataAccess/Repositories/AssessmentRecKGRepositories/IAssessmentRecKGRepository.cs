namespace Bogcha.DataAccess.Repositories.AssessmentRecKGRepositories;

public interface IAssessmentRecKGRepository
{
    public ValueTask<bool> CreateAsync(AssessmentRecKG assessmentRecKG);
    public ValueTask<bool> UpdateAsync(int id, AssessmentRecKG assessmentRecKG);
    public ValueTask<bool> DeleteAsync(int id);
    public ValueTask<AssessmentRecKG> GetByIdAsync(int id);
    public ValueTask<IEnumerable<AssessmentRecKG>> GetAllAsync();
}
