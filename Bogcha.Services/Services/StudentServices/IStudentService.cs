
using Bogcha.Infrastructure.Services.StudentServices.StudensDtos;

namespace Bogcha.Infrastructure.Services.StudentServices;

public interface IStudentService 
{
    public ValueTask<IEnumerable<Student>> GetAllStudentsAsync();
    public ValueTask<Student> GetStudentByIdAsync(string id);
    public ValueTask<bool> UpdateAsync(string chId, UpdateStudentsDto viewEmployeeDto);
    public ValueTask<bool> DeleteAsync(string chId);
    public ValueTask<bool> CreateAsync(CreateStudentsDto viewEmployeeDto);

}
