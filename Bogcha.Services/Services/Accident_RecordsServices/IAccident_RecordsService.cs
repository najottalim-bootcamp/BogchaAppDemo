
namespace Bogcha.Infrastructure.Services.Accident_RecordsServices

{
    public interface IAccident_RecordsService 
    {
        public ValueTask<bool> CreateAsync(CreateAccident_RecordsDto accident_Records);
        public ValueTask<bool> UpdateAsync(int id,UpdateAccident_RecordsDto accident_Records);
        public ValueTask<bool> DeleteAsync(int id);
        public ValueTask<ViewAccident_RecordsDto> GetByIdAsync(int id);
        public ValueTask<IEnumerable<ViewAccident_RecordsDto>> GetAllAsync();


    }
}
