namespace Bogcha.DataAccess.Repositories.ClassInfoRepositories
{
    public interface IClassInfoRepository
    {
        public ValueTask<bool> CreateAsync(ClassInfo classInfo);
        public ValueTask<bool> UpdateAsync(string ClassId, ClassInfo classInfo);
        public ValueTask<bool> DeleteAsync(string ClassId);
        public ValueTask<bool> GetByIdAsync(int id);
        public ValueTask<IEnumerable<ClassInfo>> GetAllAsync();
    }
}
