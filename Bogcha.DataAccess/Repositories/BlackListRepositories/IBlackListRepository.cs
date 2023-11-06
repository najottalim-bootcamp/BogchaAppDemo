namespace Bogcha.DataAccess.Repositories.BlackListRepositories
{
    public interface IBlackListRepository
    {
        public ValueTask<bool> CreateAsync(BlackList blackList);
        public ValueTask<bool> UpdateAsync(int id, BlackList blackList);
        public ValueTask<bool> DeleteAsync(int id);
        public ValueTask<bool> GetByIdAsync(int id);
        public ValueTask<IEnumerable<BlackList>> GetAllAsync();
    }
}
