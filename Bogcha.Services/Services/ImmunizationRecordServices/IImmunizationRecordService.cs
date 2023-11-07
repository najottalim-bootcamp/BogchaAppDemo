using Bogcha.Infrastructure.Services.ImmunizationRecordServices.ImmunizationRecordDTOs;

namespace Bogcha.Infrastructure.Services.ImmunizationRecordServices;
public interface IImmunizationRecordService
{
    public ValueTask<bool> CreateAsync(CreateImmunizationRecordDTO immunizationRecord);
    public ValueTask<bool> UpdateAsync(int id, UpdateImmunizationRecordDTO immunizationRecord);
    public ValueTask<bool> DeleteAsync(int Id);
    public ValueTask<ViewImmunizationRecordDTO> GetByIdAsync(int id);
    public ValueTask<IEnumerable<ViewImmunizationRecordDTO>> GetAllAsync();
}
