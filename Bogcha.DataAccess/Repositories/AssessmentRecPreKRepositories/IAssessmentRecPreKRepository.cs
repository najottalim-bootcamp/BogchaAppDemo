namespace Bogcha.DataAccess.Repositories.AssessmentRecPreKRepositories;

public interface IAssessmentRecPreKRepository
{
    public ValueTask<bool> CreateAsync(AssessmentRecPreK assessmentRecPreK);
    public ValueTask<bool> UpdateAsync(int id, AssessmentRecPreK assessmentRecPreK);
    public ValueTask<bool> DeleteAsync(int id);
    public ValueTask<AssessmentRecPreK> GetByIdAsync(int id);
    public ValueTask<IEnumerable<AssessmentRecPreK>> GetAllAsync();
}
