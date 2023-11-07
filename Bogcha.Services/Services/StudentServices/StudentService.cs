namespace Bogcha.Infrastructure.Services.StudentServices;

public class StudentService : IStudentService
{
    private IStudentRepository _studentRepository;

    public StudentService(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }
    public async ValueTask<bool> CreateAsync(Student entity)
    {
        return await _studentRepository.CreateAsync(entity);
    }

    public async ValueTask<bool> DeleteAsync(string id)
    {
        return await _studentRepository.DeleteAsync(id);
    }

    public async ValueTask<IEnumerable<Student>> GetAllAsync()
    {
        return await _studentRepository.GetAllAsync();
    }

    public async ValueTask<Student> GetByIdAsync(string id)
    {
        return await _studentRepository.GetByIdAsync(id);
    }

    public async ValueTask<bool> UpdateAsync(Student entity)
    {
        return await _studentRepository.UpdateAsync(entity);
    }
}
