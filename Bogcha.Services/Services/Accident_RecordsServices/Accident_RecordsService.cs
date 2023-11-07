namespace Bogcha.Infrastructure.Services.Accident_RecordsServices
{
    public class Accident_RecordsService : IAccident_RecordsService
    {
        private readonly IAccident_RecordsRepository _context;
        public Accident_RecordsService(IAccident_RecordsRepository context)
        {
            _context = context;
        }
        public async ValueTask<bool> CreateAsync(Accident_Records accident_Records)
        {
            var accidentRecords = await _context.CreateAsync(accident_Records);
            return accidentRecords;

    }

    public async ValueTask<bool> DeleteAsync(int id)
    {
        var accidentRecord = await _context.DeleteAsync(id);
        return accidentRecord;
    }

    public async ValueTask<IEnumerable<Accident_Records>> GetAllAsync()
    {
        var accidentRecord = await _context.GetAllAsync();
        return accidentRecord;
    }

    public async ValueTask<Accident_Records> GetByIdAsync(int id)
    {
        return await _context.GetByIdAsync(id);
    }

    public async ValueTask<bool> UpdateAsync(Accident_Records accident_Records)
    {
        return await _context.UpdateAsync(accident_Records);
    }
}
