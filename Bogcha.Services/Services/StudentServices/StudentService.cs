using Bogcha.Domain.Entities;
using Bogcha.Infrastructure.Services.StudentServices.StudensDtos;

namespace Bogcha.Infrastructure.Services.StudentServices;

public class StudentService : IStudentService
{
    private IStudentRepository _studentRepository;
    private IParentRepository _parentRepository;
    private IAccident_RecordsRepository _accident_RecordsRepository;
    private IAttendanceRepository _attendanceRepository;
    private IBlackListRepository _blackListRepository;
    private IImmunizationRecordRepository _immunizationRecordRepository;
    private IRevenueRepository _revenueRepository;
    private RegularHealthCheckRepository _regularHealthCheckRepository;
    private IMapper _mapper;

    public StudentService(IStudentRepository studentRepository,IParentRepository parentRepository,IAccident_RecordsRepository accident_RecordsRepository,
        IAttendanceRepository attendanceRepository,IBlackListRepository blackListRepository,IImmunizationRecordRepository immunizationRecordRepository,
        IRevenueRepository revenueRepository,RegularHealthCheckRepository regularHealthCheckRepository,IMapper mapper)
    {
        _studentRepository = studentRepository;
        _parentRepository = parentRepository;
        _accident_RecordsRepository = accident_RecordsRepository;
        _attendanceRepository = attendanceRepository;
        _blackListRepository = blackListRepository;
        _immunizationRecordRepository = immunizationRecordRepository;
        _revenueRepository = revenueRepository;
        _regularHealthCheckRepository = regularHealthCheckRepository;
        _mapper = mapper;

    }

    public async ValueTask<bool> CreateAsync(CreateStudentsDto createStudentsDto)
    {

        var paren = _mapper.Map<Student>(createStudentsDto);
        bool res = await _studentRepository.CreateAsync(paren);
        return res;
    }

    public async ValueTask<bool> DeleteAsync(string chId)
    {
        bool res = await _studentRepository.DeleteAsync(chId);
        return res;
    }

    public async ValueTask<IEnumerable<Student>> GetAllStudentsAsync()
    {
        var res = await _studentRepository.GetAllAsync();
        return res;
    }

    public async  ValueTask<Student> GetStudentByIdAsync(string id)
    {
        var res = await _studentRepository.GetByIdAsync(id);
        return res;
    }

    public async ValueTask<bool> UpdateAsync(string chId, UpdateStudentsDto viewEmployeeDto)
    {
        var repo = await _studentRepository.GetByIdAsync(chId);

        if (repo is null)
        {
            return false;
        }

        var parent = _mapper.Map<Student>(viewEmployeeDto);
        parent.CHId = chId;

        bool res = await _studentRepository.UpdateAsync(parent);
        return res;
    }
}
