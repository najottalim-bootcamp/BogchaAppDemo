using Bogcha.Domain.Entities;

namespace Bogcha.DataAccess.Repositories.AssessmentRecPreKRepositories;

public interface IAssessmentRecPreKRepository
{
    public ValueTask<bool> CreateAsync(AssessmentRecPreK assessmentRecPreK);
    public ValueTask<bool> UpdateAsync(int id, AssessmentRecPreK assessmentRecPreK);
    public ValueTask<bool> DeleteAsync(int id);
    public ValueTask<bool> GetByIdAsync(int id);
    public ValueTask<IEnumerable<AssessmentRecPreK>> GetAllAsync();
}
