namespace Bogcha.Infrastructure.Services.ImmunizationRecordServices;
public class ImmunizationRecordService : IImmunizationRecordService
{
    private IImmunizationRecordRepository _immunizationRecordRepository;

    public ImmunizationRecordService(IImmunizationRecordRepository immunizationRecordRepository)
    {
        _immunizationRecordRepository = immunizationRecordRepository;
    }
    public async ValueTask<bool> CreateAsync(ImmunizationRecord immunizationRecord)
    {
        return await _immunizationRecordRepository.CreateAsync(immunizationRecord);
    }

    public async ValueTask<bool> DeleteAsync(int Id)
    {
        return await _immunizationRecordRepository.DeleteAsync(Id);
    }

    public async ValueTask<IEnumerable<ImmunizationRecord>> GetAllAsync()
    {
        return await _immunizationRecordRepository.GetAllAsync();
    }

    public async ValueTask<ImmunizationRecord> GetByIdAsync(int Id)
    {
        return await _immunizationRecordRepository.GetByIdAsync(Id);
    }

    public async ValueTask<bool> UpdateAsync(ImmunizationRecord immunizationRecord)
    {
        return await _immunizationRecordRepository.UpdateAsync(immunizationRecord);
    }
}
