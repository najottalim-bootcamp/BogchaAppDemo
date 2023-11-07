namespace Bogcha.Infrastructure.Services.EmployeeServices;

public class EmployeeService : IEmployeeService
{
    private IEmployeeRepository _employee;
    private IMapper _mapper;

    public EmployeeService(IEmployeeRepository employee, IMapper mapper)
    {
        _employee = employee;
        _mapper = mapper;
    }

    public async ValueTask<bool> CreateAsync(CreateEmployeeDto viewEmployeeDto)
    {
        var paren = _mapper.Map<Employee>(viewEmployeeDto);
        bool res = await _employee.CreateAsync(paren);
        return res;
    }

    public async ValueTask<bool> DeleteAsync(string chId)
    {
        bool res = await _employee.DeleteAsync(chId);
        return res;
    }

    public async ValueTask<IEnumerable<Employee>> GetAllEmployeeAsync()
    {
        var res = await _employee.GetAllAsync();
        return res;

    }

    public async ValueTask<Employee> GetEmployeeByIdAsync(string id)
    {
        var res = await _employee.GetByIdAsync(id);
        return res;
    }

    public async ValueTask<bool> UpdateAsync(string EmpId, UpdateEmployeeDto viewEmployeeDto)
    {
        var repo = await _employee.GetByIdAsync(EmpId);

        if (repo is null)
        {
            return false;
        }

        var parent = _mapper.Map<Employee>(viewEmployeeDto);
        parent.EmpId = EmpId;

        bool res = await _employee.UpdateAsync(parent);
        return res;
    }
}
