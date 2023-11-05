namespace Bogcha.Services.Services.RevenueServices;

public class RevenueService : IRevenueService
{
    private readonly IRevenueRepository revenueRepository;

    public RevenueService(IRevenueRepository revenueRepository)
    {
        this.revenueRepository = revenueRepository;
    }

    public ValueTask<IEnumerable<Revenue>> GetAllAsync()
    {
        return revenueRepository.GetAllAsync();
    }

    public ValueTask<Revenue> GetByIdAsync(string ChId)
    {
        return revenueRepository.GetByIdAsync(ChId);
    }
    public ValueTask<bool> CreateAsync(Revenue revenue)
    {
        return revenueRepository.CreateAsync(revenue);
    }


    public ValueTask<bool> UpdateAsync(Revenue revenue)
    {
        return revenueRepository.UpdateAsync(revenue);
    }
    public ValueTask<bool> DeleteAsync(string ChId)
    {
        return revenueRepository.DeleteAsync(ChId);
    }
}
