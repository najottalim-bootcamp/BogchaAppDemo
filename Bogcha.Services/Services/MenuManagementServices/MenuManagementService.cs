namespace Bogcha.Services.Services.MenuManagementServices;

public class MenuManagementService : IMenuManagementService
{
    private readonly IMenuManagementRepository menuManagementRepository;

    public MenuManagementService(IMenuManagementRepository menuManagementRepository)
    {
        this.menuManagementRepository = menuManagementRepository;
    }
    public async ValueTask<bool> CreateAsync(MenuManagement menuManagement)
    {
        return await menuManagementRepository.CreateAsync(menuManagement);
    }

    public async ValueTask<bool> DeleteAsync(string ChId)
    {
        return await menuManagementRepository.DeleteAsync(ChId);
    }

    public async ValueTask<IEnumerable<MenuManagement>> GetAllAsync()
    {
        return await menuManagementRepository.GetAllAsync();
    }

    public async ValueTask<MenuManagement> GetByIdAsync(string ChId)
    {
        return await menuManagementRepository.GetByIdAsync(ChId);
    }

    public async ValueTask<bool> UpdateAsync(MenuManagement menuManagement)
    {
        return await menuManagementRepository.UpdateAsync(menuManagement);
    }
}
