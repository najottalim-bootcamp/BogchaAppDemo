namespace Bogcha.Infrastructure.Services.BlackListServices;
public class BlackListService : IBlackListService
{
    private IBlackListRepository _blackListRepository;

    public BlackListService(IBlackListRepository blackListRepository)
    {
        _blackListRepository = blackListRepository;
    }
    public async ValueTask<bool> CreateAsync(BlackList blackList)
    {
        return await _blackListRepository.CreateAsync(blackList);
    }

    public async ValueTask<bool> DeleteAsync(string ChId)
    {
        return await _blackListRepository.DeleteAsync(ChId);
    }

    public async ValueTask<IEnumerable<BlackList>> GetAllAsync()
    {
        return await _blackListRepository.GetAllAsync();
    }

    public async ValueTask<BlackList> GetByIdAsync(string ChId)
    {
        return await _blackListRepository.GetByIdAsync(ChId);
    }

    public async ValueTask<bool> UpdateAsync(BlackList blackList)
    {
        return await _blackListRepository.UpdateAsync(blackList);
    }
}
