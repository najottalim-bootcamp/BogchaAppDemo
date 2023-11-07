using Bogcha.DataAccess.Repositories.Accident_RecordsRepositories;
using Bogcha.DataAccess.Repositories.StudentRepositories;
using Bogcha.Domain.Entities;
using Bogcha.Infrastructure.Services.ActivityManagementServices.ActivityManagemntDtos;

namespace Bogcha.Infrastructure.Services.ActivityManagementServices
{
    public class ActivityManagementService : IActivityManagementService
    {
        private readonly IEmployeeRepository employeeRepository;
        private readonly IActivityManagementRepository _activityManagementRepository;
        private IMapper mapper;
        public ActivityManagementService(IActivityManagementRepository context, 
            IEmployeeRepository employeeRepository, 
            IMapper mapper)
        {
            _activityManagementRepository = context;
            this.employeeRepository = employeeRepository;
            this.mapper = mapper;
        }

        public async ValueTask<bool> CreateAsync(CreateActivityManagementDto activityManagementDto)
        {
            var activityManagement = mapper.Map<ActivityManagement>(activityManagementDto);
            return await _activityManagementRepository.CreateAsync(activityManagement);
        }

        public async ValueTask<bool> DeleteAsync(int id)
        {
            return await _activityManagementRepository.DeleteAsync(id);
        }

        public async ValueTask<IEnumerable<ViewActivityManagementDto>> GetAllAsync()
        {
            IEnumerable<ActivityManagement> activityManagements = await _activityManagementRepository.GetAllAsync();
            IEnumerable<Employee> employees = await employeeRepository.GetAllAsync();
            if (!(activityManagements.Any() && employees.Any()))
            {
                return Enumerable.Empty<ViewActivityManagementDto>();
            }
            IEnumerable<ViewActivityManagementDto> viewActivityManagement = activityManagements.Join(
                employees,
                activityManagement => activityManagement.Led_by,
                employee => employee.EmpId,
                (activityManagement,employee) => new ViewActivityManagementDto()
                {
                    Id = activityManagement.Id,
                    empFName = employee.EmpFName,
                    empLName = employee.EmpLName,
                    email = employee.Email,
                    phoneNO=employee.PhoneNo,
                    Task = activityManagement.Task,
                    Time = activityManagement.Time
                });

            return viewActivityManagement;
        }

        public async ValueTask<ViewActivityManagementDto> GetByIdAsync(int id)
        {
            ActivityManagement activityManagement = await _activityManagementRepository.GetByIdAsync(id);
            Employee employee = await employeeRepository.GetByIdAsync(activityManagement.Led_by);
            if (activityManagement is null && employee is null)
            {
                return null;
            }
            ViewActivityManagementDto viewActivityManagement =new ViewActivityManagementDto()
                {
                    Id = activityManagement.Id,
                    empFName = employee.EmpFName,
                    empLName = employee.EmpLName,
                    email = employee.Email,
                    phoneNO = employee.PhoneNo,
                    Task = activityManagement.Task,
                    Time = activityManagement.Time
                };

            return viewActivityManagement;

        }

        public async ValueTask<bool> UpdateAsync(int id,UpdateActivityManagementDto UpdateactivityManagement)
        {
            ActivityManagement activityManagement = mapper.Map<ActivityManagement>(UpdateactivityManagement);
            activityManagement.Id = id;
            return await _activityManagementRepository.UpdateAsync(activityManagement);
        }
    }
}
