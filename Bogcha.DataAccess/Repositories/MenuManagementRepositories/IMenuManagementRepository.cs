namespace Bogcha.DataAccess.Repositories.MenuManagementRepositories;

public interface IMenuManagementRepository
{
    public ValueTask<bool> CreateAsync(MenuManagement menuManagement);
    public ValueTask<bool> UpdateAsync(MenuManagement menuManagement);
    public ValueTask<bool> DeleteAsync(string ChId);
    public ValueTask<MenuManagement> GetByIdAsync(string ChId);
    public ValueTask<IEnumerable<MenuManagement>> GetAllAsync();
}
