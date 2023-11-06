namespace Bogcha.DataAccess.Repositories.AssessmentRecNurseryRepositories;

public interface IAssessmentRecNurseryRepository
{
    public ValueTask<bool> CreateAsync(AssessmentRecNursery assessmentRecKnursery);
    public ValueTask<bool> UpdateAsync(int id, AssessmentRecNursery assessmentRecnursery);
    public ValueTask<bool> DeleteAsync(int id);
    public ValueTask<AssessmentRecNursery> GetByIdAsync(int id);
    public ValueTask<IEnumerable<AssessmentRecNursery>> GetAllAsync();
}
