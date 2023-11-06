using Bogcha.DataAccess.Repositories.ActivityManagementRepositories;

namespace Bogcha.Services.Services.ActivityManagementServices
{
    public class ActivityManagementService:IActivityManagementService
    {
        private readonly IActivityManagementRepository _activityManagementRepository;
        public ActivityManagementService(IActivityManagementRepository context)
        {
            _activityManagementRepository = context;
        }

        public async ValueTask<bool> CreateAsync(ActivityManagement activityManagement)
        {
            return await _activityManagementRepository.CreateAsync(activityManagement);
        }

        public async ValueTask<bool> DeleteAsync(int id)
        {
            return await _activityManagementRepository.DeleteAsync(id);
        }

        public async ValueTask<IEnumerable<ActivityManagement>> GetAllAsync()
        {
            return await  _activityManagementRepository.GetAllAsync();
        }

        public async ValueTask<ActivityManagement> GetByIdAsync(int id)
        {
            return await _activityManagementRepository.GetByIdAsync(id);
        }

        public async ValueTask<bool> UpdateAsync(ActivityManagement activityManagement)
        {
            return await _activityManagementRepository.UpdateAsync(activityManagement);
        }
    }
}
