namespace Bogcha.Services.Services.WithdrawalServices;

public class WithdrawalService : IWithdrawalService
{
    private readonly IWithdrawalRepository withdrawalRepository;

    public WithdrawalService(IWithdrawalRepository withdrawalRepository)
    {
        this.withdrawalRepository = withdrawalRepository;
    }
    public async ValueTask<bool> CreateAsync(Withdrawal withdrawal)
    {
        return await withdrawalRepository.CreateAsync(withdrawal);
    }

    public async ValueTask<bool> DeleteAsync(int id)
    {
        return await withdrawalRepository.DeleteAsync(id);
    }

    public async ValueTask<IEnumerable<Withdrawal>> GetAllAsync()
    {
        return await withdrawalRepository.GetAllAsync();
    }

    public async ValueTask<Withdrawal> GetByIdAsync(int id)
    {
        return await withdrawalRepository.GetByIdAsync(id);
    }

    public async ValueTask<bool> UpdateAsync(Withdrawal withdrawal)
    {
        return await withdrawalRepository.UpdateAsync(withdrawal);
    }
}
