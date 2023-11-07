namespace Bogcha.DataAccess.Repositories.BlackListRepositories
{
    public interface IBlackListRepository
    {
        public ValueTask<bool> CreateAsync(BlackList blackList);
        public ValueTask<bool> UpdateAsync(BlackList blackList);
        public ValueTask<bool> DeleteAsync(string ChId);
        public ValueTask<BlackList> GetByIdAsync(string ChId);
        public ValueTask<IEnumerable<BlackList>> GetAllAsync();
    }
}
