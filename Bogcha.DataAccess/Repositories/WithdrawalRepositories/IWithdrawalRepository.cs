using Bogcha.Domain.Entities;

namespace Bogcha.DataAccess.Repositories.WithdrawalRepositories;

public interface IWithdrawalRepository
{
    public ValueTask<bool> CreateAsync(Withdrawal withdrawal);
    public ValueTask<bool> UpdateAsync(int id, Withdrawal withdrawal);
    public ValueTask<bool> DeleteAsync(int id);
    public ValueTask<Withdrawal> GetByIdAsync(int id);
}
