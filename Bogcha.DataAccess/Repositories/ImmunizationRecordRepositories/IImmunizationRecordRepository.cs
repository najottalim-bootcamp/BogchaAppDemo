namespace Bogcha.DataAccess.Repositories.ImmunizationRecordRepositories
{
    public interface IImmunizationRecordRepository
    {
        public ValueTask<bool> CreateAsync(ImmunizationRecord immunizationRecord);
        public ValueTask<bool> UpdateAsync(ImmunizationRecord immunizationRecord);
        public ValueTask<bool> DeleteAsync(int Id);
        public ValueTask<ImmunizationRecord> GetByIdAsync(int Id);
        public ValueTask<IEnumerable<ImmunizationRecord>> GetAllAsync();
    }
}
