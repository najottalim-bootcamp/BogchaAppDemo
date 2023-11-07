
namespace Bogcha.Infrastructure.Services.ActivityManagementServices;

    public interface IActivityManagementService 
    {
        public ValueTask<bool> CreateAsync(CreateActivityManagementDto activityManagementDto);
        public ValueTask<bool> UpdateAsync(int id,UpdateActivityManagementDto UpdateactivityManagement);
        public ValueTask<bool> DeleteAsync(int id);
        public ValueTask<ViewActivityManagementDto> GetByIdAsync(int id);
        public ValueTask<IEnumerable<ViewActivityManagementDto>> GetAllAsync();

    }

