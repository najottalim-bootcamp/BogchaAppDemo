namespace Bogcha.Services.Services.EmployeeServices;

public class EmployeeService : IEmployeeService
{
    private IEmployeeRepository _employee;

    public EmployeeService(IEmployeeRepository employee)
    {
        _employee = employee;
    }
    public async ValueTask<bool> CreateAsync(Employee entity)
    {
        return await _employee.CreateAsync(entity);
    }

    public async ValueTask<bool> DeleteAsync(string id)
    {
        return await _employee.DeleteAsync(id);
    }

    public async ValueTask<IEnumerable<Employee>> GetAllAsync()
    {
        return await _employee.GetAllAsync();
    }

    public async ValueTask<Employee> GetByIdAsync(string id)
    {
        return await _employee.GetByIdAsync(id);
    }

    public async ValueTask<bool> UpdateAsync(Employee entity)
    {
        return await _employee.UpdateAsync(entity);
    }
}
