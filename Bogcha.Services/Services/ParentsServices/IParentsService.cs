using Bogcha.Infrastructure.Services.ParentsServices.ParentsDtos;

namespace Bogcha.Infrastructure.Services.ParentsServices;

public interface IParentsService 
{
    public ValueTask<IEnumerable<ViewParentDto>> GetAllParentsAsync();
    public ValueTask<ViewParentDto> GetParentsByIdAsync(string id);
    public ValueTask<bool> UpdateAsync(string chId,UpdateParentsDto viewParentDto);
    public ValueTask<bool> DeleteAsync(string chId);
    public ValueTask<bool> CreateAsync(CreateParentsDto viewParentDto);
}
