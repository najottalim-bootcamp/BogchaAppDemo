
namespace Bogcha.Infrastructure.Services.RegularHealthCheckServices;

public class RegularHealthCheckService : IRegularHealthCheckService
{
    private readonly IRegularHealthCheckRepository regularRepository;
    private readonly IStudentRepository studentRepository;
    private IMapper mapper;
    public RegularHealthCheckService(IRegularHealthCheckRepository repository, IStudentRepository studentRepository, IMapper mapper)
    {
        regularRepository = repository;
        this.studentRepository = studentRepository;
        this.mapper = mapper;
    }
    public async ValueTask<bool> CreateAsync(CreateRegularHealthCheckDto regularHealthCheck)
    {
        RegularHealthCheck regularHealthCheck1 = mapper.Map<RegularHealthCheck>(regularHealthCheck);

        return await regularRepository.CreateAsync(regularHealthCheck1);
    }

    public async ValueTask<bool> DeleteAsync(int id)
    {
        return await regularRepository.DeleteAsync(id);
    }

    public async ValueTask<IEnumerable<ViewRegularHealthCheckDto>> GetAllAsync()
    {
        IEnumerable<RegularHealthCheck> regularHealthChecks = await regularRepository.GetAllAsync();
        IEnumerable<Student> students = await studentRepository.GetAllAsync();
        if (!(students.Any() && regularHealthChecks.Any())) return Enumerable.Empty<ViewRegularHealthCheckDto>();
        IEnumerable<ViewRegularHealthCheckDto> viewRegularHealthCheckDtos =
            regularHealthChecks.Join(students, rhc => rhc.ChId, student => student.CHId,
            (regHc, student) => new ViewRegularHealthCheckDto
            {
                Id = regHc.Id,
                CheckupDate = regHc.CheckupDate,
                ChFName = student.ChFName,
                ChLName = student.ChLName,
                ActionRequired = regHc.ActionRequired,
                Symptom = regHc.Symptom,
                AllergySymptom = student.AllergySymptom,
                AllergyType = student.AllergyType,
                gender = student.Gender
            }
            );
        return viewRegularHealthCheckDtos;
    }

    public async ValueTask<ViewRegularHealthCheckDto> GetByIdAsync(int id)
    {
        RegularHealthCheck regHc = await regularRepository.GetByIdAsync(id);
        Student student = await studentRepository.GetByIdAsync(regHc.ChId);
        if (student is null || regHc is null) return null;
        ViewRegularHealthCheckDto view =
        new ViewRegularHealthCheckDto
        {
            Id = regHc.Id,
            CheckupDate = regHc.CheckupDate,
            ChFName = student.ChFName,
            ChLName = student.ChLName,
            ActionRequired = regHc.ActionRequired,
            Symptom = regHc.Symptom,
            AllergySymptom = student.AllergySymptom,
            AllergyType = student.AllergyType,
            gender = student.Gender
        };
        return view;
    }

    public async ValueTask<bool> UpdateAsync(int id, UpdateRegularHealthCheckDto regularHealthCheck)
    {
        RegularHealthCheck rGetById = await regularRepository.GetByIdAsync(id);
        RegularHealthCheck rmapping = mapper.Map<RegularHealthCheck>(regularHealthCheck);
        rmapping.ChId = rGetById.ChId;
        rmapping.Id = id;

        return await regularRepository.UpdateAsync(rmapping);
    }
}
