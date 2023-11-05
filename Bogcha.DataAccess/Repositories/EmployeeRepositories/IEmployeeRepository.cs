namespace Bogcha.DataAccess.Repositories.EmployeeRepositories;

public interface IEmployeeRepository
{

    public ValueTask<bool> CreateAsync(Employee entity);

    public ValueTask<bool> UpdateAsync(Employee entity);

    public ValueTask<bool> DeleteAsync(string id);

    public ValueTask<Employee> GetByIdAsync(string id);
    public ValueTask<IEnumerable<Employee>> GetAllAsync();


}
