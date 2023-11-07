namespace Bogcha.Infrastructure.Services.WithdrawalServices;

public interface IWithdrawalService
{
    ValueTask<bool> CreateAsync(CreateWithdrawalDto createWithdrawal);
    ValueTask<bool> DeleteAsync(int id);
    ValueTask<IEnumerable<ViewWithdrawalDto>> GetAllAsync();
    ValueTask<ViewWithdrawalDto> GetByIdAsync(int id);
    ValueTask<bool> UpdateAsync(int id, UpdateWithdrawalDto updateWithdrawal);
}