using Bogcha.Services.Services.RevenueServices.RevenueDtos;

namespace Bogcha.Services.Services.RevenueServices;

public interface IRevenueService
{
    public ValueTask<IEnumerable<ViewRevenueDto>> GetAllRevenuesAsync();
    public ValueTask<ViewRevenueDto> GetRevenueByIdAsync(string id);
    public ValueTask<bool> UpdateAsync(string chId, UpdateRevenueDto updateRevenueDto);
    public ValueTask<bool> DeleteAsync(string chId);
    public ValueTask<bool> CreateAsync(CreateRevenueDto createRevenueDto);
}
