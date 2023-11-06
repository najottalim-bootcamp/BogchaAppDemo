using Bogcha.Domain.Entities;

namespace Bogcha.DataAccess.Repositories.Accident_RecordsRepositories
{
    public interface IAccident_RecordsRepository
    {
        public ValueTask<bool> CreateAsync(Accident_Records accident_Records);
        public ValueTask<bool> UpdateAsync(Accident_Records accident_Records);
        public ValueTask<bool> DeleteAsync(int id);
        public ValueTask<Accident_Records> GetByIdAsync(int id);
        public ValueTask<IEnumerable<Accident_Records>> GetAllAsync();

    }
}
