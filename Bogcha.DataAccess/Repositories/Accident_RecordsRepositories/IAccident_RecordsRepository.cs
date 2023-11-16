namespace Bogcha.DataAccess.Repositories.Accident_RecordsRepositories;

public interface IAccident_RecordsRepository
{
    public ValueTask<bool> CreateAsync(AccidentRecords accident_Records);
    public ValueTask<bool> UpdateAsync(AccidentRecords accident_Records);
    public ValueTask<bool> DeleteAsync(int id);
    public ValueTask<AccidentRecords> GetByIdAsync(int id);
    public ValueTask<IEnumerable<AccidentRecords>> GetAllAsync();

}
