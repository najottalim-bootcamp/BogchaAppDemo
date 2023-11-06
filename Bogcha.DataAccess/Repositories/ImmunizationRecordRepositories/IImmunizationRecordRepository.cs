namespace Bogcha.DataAccess.Repositories.ImmunizationRecordRepositories;

public interface IImmunizationRecordRepository
{
    public ValueTask<bool> CreateAsync(ImmunizationRecord immunizationRecord);
    public ValueTask<bool> UpdateAsync(int id, ImmunizationRecord immunizationRecord);
    public ValueTask<bool> DeleteAsync(int id);
    public ValueTask<bool> GetByIdAsync(int id);
    public ValueTask<IEnumerable<ImmunizationRecord>> GetAllAsync();
}
