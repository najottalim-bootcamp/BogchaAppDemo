using Bogcha.Infrastructure.Services.ParentsServices.ParentsDtos;

namespace Bogcha.Infrastructure.Services.ParentsServices;

public interface IParentsService 
{
    public ValueTask<IEnumerable<ViewParentDto>> GetAllRevenuesAsync();
    public ValueTask<ViewParentDto> GetRevenueByIdAsync(string id);
    public ValueTask<bool> UpdateAsync(string chId, ViewParentDto viewParentDto);
    public ValueTask<bool> DeleteAsync(string chId);
    public ValueTask<bool> CreateAsync(ViewParentDto viewParentDto);
}
