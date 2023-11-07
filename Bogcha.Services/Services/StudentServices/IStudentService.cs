
using Bogcha.Infrastructure.Services.StudentServices.StudensDtos;

namespace Bogcha.Infrastructure.Services.StudentServices;

public interface IStudentService 
{
    public ValueTask<IEnumerable<ViewStudentDto>> GetAllStudentsAsync();
    public ValueTask<ViewStudentDto> GetStudentByIdAsync(string id);
    public ValueTask<bool> UpdateAsync(string chId, UpdateStudentsDto viewEmployeeDto);
    public ValueTask<bool> DeleteAsync(string chId);
    public ValueTask<bool> CreateAsync(CreateStudentsDto viewEmployeeDto);

}
