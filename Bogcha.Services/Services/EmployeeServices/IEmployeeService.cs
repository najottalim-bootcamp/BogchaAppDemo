using Bogcha.Infrastructure.Services.EmployeeServices.EmployeeDtos;


namespace Bogcha.Infrastructure.Services.EmployeeServices;

public interface IEmployeeService 
{
    public ValueTask<IEnumerable<Employee>> GetAllEmployeeAsync();
    public ValueTask<Employee> GetEmployeeByIdAsync(string id);
    public ValueTask<bool> UpdateAsync(string chId, UpdateEmployeeDto viewEmployeeDto);
    public ValueTask<bool> DeleteAsync(string chId);
    public ValueTask<bool> CreateAsync(CreateEmployeeDto viewEmployeeDto);

}
