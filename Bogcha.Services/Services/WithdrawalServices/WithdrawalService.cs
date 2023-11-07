namespace Bogcha.Infrastructure.Services.WithdrawalServices;

public class WithdrawalService : IWithdrawalService
{
    private readonly IWithdrawalRepository _withdrawalRepository;
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IMapper _mapper;

    public WithdrawalService(
        IWithdrawalRepository withdrawalRepository,
        IEmployeeRepository employeeRepository,
        IMapper mapper
        )
    {
        _withdrawalRepository = withdrawalRepository;
        _employeeRepository = employeeRepository;
        _mapper = mapper;
    }
    public async ValueTask<bool> CreateAsync(CreateWithdrawalDto createWithdrawal)
    {
        Withdrawal withdrawal = _mapper.Map<Withdrawal>(createWithdrawal);

        bool result = await _withdrawalRepository.CreateAsync(withdrawal);
        return result;
    }


    public async ValueTask<bool> DeleteAsync(int id)
    {
        bool result = await _withdrawalRepository.DeleteAsync(id);
        return result;
    }

    public async ValueTask<IEnumerable<ViewWithdrawalDto>> GetAllAsync()
    {
        IEnumerable<Withdrawal> withdrawals = await _withdrawalRepository.GetAllAsync();
        IEnumerable<Employee> employees = await _employeeRepository.GetAllAsync();

        if (!(withdrawals.Any() && employees.Any()))
        {
            return Enumerable.Empty<ViewWithdrawalDto>();
        }
        IEnumerable<ViewWithdrawalDto> viewWithdrawalDtos = withdrawals.Join(
            employees,
            withdrawal => withdrawal.WithDrawnBy,
            emp => emp.EmpId,
            (withdrawal, employee) => new ViewWithdrawalDto()
            {
                Id = withdrawal.Id,
                Expense = withdrawal.Expense,
                Amount = withdrawal.Amount,
                DatePaid = withdrawal.DatePaid,
                EmployeeFName = employee.EmpFName,
                EmployeeLName = employee.EmpLName,
                Department = employee.Department
            });
        return viewWithdrawalDtos;
    }

    public async ValueTask<Withdrawal> GetByIdAsync(int id)
    {
        Withdrawal withdrawal = await _withdrawalRepository.GetByIdAsync(id);
        Employee employee = await _employeeRepository.GetByIdAsync(withdrawal.WithDrawnBy);
        if (employee is null || withdrawal is null)
        {
            return null;
        }
        var veiwWithdrawal = new ViewWithdrawalDto()
        {
            Id = withdrawal.Id,
            Expense = withdrawal.Expense,
            Amount = withdrawal.Amount,
            DatePaid = withdrawal.DatePaid,
            EmployeeFName = employee.EmpFName,
            EmployeeLName = employee.EmpLName,
            Department = employee.Department
        };
        return withdrawal;

    }

    public async ValueTask<bool> UpdateAsync(int id, UpdateWithdrawalDto updateWithdrawal)
    {
        Withdrawal withdrawal = _mapper.Map<Withdrawal>(updateWithdrawal);
        withdrawal.Id = id;

        bool result = await _withdrawalRepository.UpdateAsync(withdrawal);
        return result;
    }
}
