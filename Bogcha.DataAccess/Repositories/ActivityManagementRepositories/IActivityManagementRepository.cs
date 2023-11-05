using Bogcha.Domain.Entities;

namespace Bogcha.DataAccess.Repositories.ActivityManagementRepositories
{
    public interface IActivityManagementRepository
    {

        public ValueTask<bool> CreateAsync(ActivityManagement activityManagement);
        public ValueTask<bool> UpdateAsync(int id, ActivityManagement activityManagement);
        public ValueTask<bool> DeleteAsync(int id);
        public ValueTask<ActivityManagement> GetByIdAsync(int id);
        public ValueTask<IEnumerable<ActivityManagement>> GetAllAsync();
    }
}
