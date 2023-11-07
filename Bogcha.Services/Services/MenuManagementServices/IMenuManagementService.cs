namespace Bogcha.Infrastructure.Services.MenuManagementServices;

public interface IMenuManagementService
{
    ValueTask<bool> CreateMenuManagement(CreateMenuManagementDto createMenuManagementDto);
    ValueTask<bool> DeleteMenuManagementAsync(string chId);
    ValueTask<IEnumerable<ViewMenuManagementDto>> GetAllMenusAsync();
    ValueTask<ViewMenuManagementDto> GetMenuManagementByIdAsync(string chId);
    ValueTask<bool> UpdateMenuManagementAsync(string chId, UpdateMealPlanDto updateMealPlanDto);
}