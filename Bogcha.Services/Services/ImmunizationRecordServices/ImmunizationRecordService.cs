using Bogcha.Domain.Entities;
using Bogcha.Infrastructure.Services.BlackListServices.BlackListDTOs;
using Bogcha.Infrastructure.Services.ImmunizationRecordServices.ImmunizationRecordDTOs;
using System.Linq;

namespace Bogcha.Infrastructure.Services.ImmunizationRecordServices;
public class ImmunizationRecordService : IImmunizationRecordService
{
    private readonly IStudentRepository _studentRepository;
    private IImmunizationRecordRepository _immunizationRecordRepository;
    private IMapper mapper;

    public ImmunizationRecordService(IImmunizationRecordRepository immunizationRecordRepository)
    {
        _immunizationRecordRepository = immunizationRecordRepository;
        this.mapper = mapper;
    }
    public async ValueTask<bool> CreateAsync(CreateImmunizationRecordDTO immunizationRecord)
    {
        ImmunizationRecord immunizationRecord1 = mapper.Map<ImmunizationRecord>(immunizationRecord);
        return await _immunizationRecordRepository.CreateAsync(immunizationRecord1);
    }

    public async ValueTask<bool> DeleteAsync(int Id)
    {
        return await _immunizationRecordRepository.DeleteAsync(Id);
    }

    public async ValueTask<IEnumerable<ViewImmunizationRecordDTO>> GetAllAsync()
    {
        IEnumerable<Student> students = await _studentRepository.GetAllAsync();
        IEnumerable<ImmunizationRecord> immunizationRecords= await _immunizationRecordRepository.GetAllAsync();

        if (!(students.Any() && immunizationRecords.Any()))
        {
            return Enumerable.Empty<ViewImmunizationRecordDTO>();
        }
        IEnumerable<ViewImmunizationRecordDTO> immunizationRecordsDTOs = immunizationRecords.Join(
            students,
            im => im.Id,
            std => std.CHId,
            (immunizationRecords, student) => new ViewImmunizationRecordDTO()
            {
                Id = immunizationRecords.Id,
                CHId = student.CHId,
                ChFName = student.ChFName,
                ChLName = student.ChLName,
            });
        return immunizationRecordsDTOs;
    }

    public async ValueTask<ImmunizationRecord> GetByIdAsync(int Id)
    {

        ImmunizationRecord? immunizationRecords = await _immunizationRecordRepository.GetByIdAsync(Id);
        if (immunizationRecords == null) 
        {
            return null;
        }
        Student? student = await _studentRepository.GetByIdAsync(immunizationRecords.ChId);

        if (student is null || immunizationRecords is null)
        {
            return null;
        }
        var immunizationRecordsView = new ViewImmunizationRecordDTO()
        {
            Id = immunizationRecords.Id,
            CHId = student.CHId,
            ChFName = student.ChFName,
            ChLName = student.ChLName,

        };
        return immunizationRecords;
    }

    public async ValueTask<bool> UpdateAsync(ImmunizationRecord immunizationRecord)
    {
        var immunizationRecord1 = await _immunizationRecordRepository.GetByIdAsync(immunizationRecord.Id);
        if (immunizationRecord1 is null)
        {
            return false;
        }
        immunizationRecord1 = mapper.Map<ImmunizationRecord>(immunizationRecord);
        immunizationRecord1.ChId = immunizationRecord.ChId;
        immunizationRecord1.Id = immunizationRecord.Id;

        bool result = await _immunizationRecordRepository.UpdateAsync(immunizationRecord1);
        return result;
    }
}
