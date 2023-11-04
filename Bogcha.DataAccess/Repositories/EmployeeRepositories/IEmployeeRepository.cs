using Bogcha.Domain.Entities;

namespace Bogcha.DataAccess.Repositories.EmployeeRepositories;

public interface IEmployeeRepository
{

    public ValueTask<bool> CreateAsync(Employee entity);

    public ValueTask<bool> UpdateAsync(string id, Employee entity);

    public ValueTask<bool> DeleteAsync(string id);

    public ValueTask<IEnumerable<Employee>> GetAllAsync();

    public ValueTask<Employee> GetByIdAsync(string id);

}
