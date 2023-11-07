using Bogcha.Infrastructure.Services.BlackListServices.BlackListDTOs;

namespace Bogcha.Infrastructure.Services.BlackListServices;
public interface IBlackListService
{
    public ValueTask<bool> CreateAsync(CreateBlackListDTO blackList);
    public ValueTask<bool> UpdateAsync(string id, UpdateBlackListDTO blackList);
    public ValueTask<bool> DeleteAsync(string ChId);
    public ValueTask<ViewBlackListDTO> GetByIdAsync(string ChId);
    public ValueTask<IEnumerable<ViewBlackListDTO>> GetAllAsync();
}
