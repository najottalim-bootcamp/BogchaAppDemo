namespace Bogcha.DataAccess.Repositories.RevenuesRepositories;

public interface IRevenueRepository
{
    public ValueTask<bool> CreateAsync(Revenue revenue);
    public ValueTask<bool> UpdateAsync(Revenue revenue);
    public ValueTask<bool> DeleteAsync(string ChId);
    public ValueTask<Revenue> GetByIdAsync(string ChId);
    public ValueTask<IEnumerable<Revenue>> GetAllAsync();
}
