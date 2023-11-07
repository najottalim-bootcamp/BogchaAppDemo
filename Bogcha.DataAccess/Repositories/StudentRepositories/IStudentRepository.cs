namespace Bogcha.DataAccess.Repositories.StudentRepositories;

public interface IStudentRepository
{
    public ValueTask<bool> CreateAsync(Student entity);

    public ValueTask<bool> UpdateAsync(Student entity);

    public ValueTask<bool> DeleteAsync(string id);

    public ValueTask<Student> GetByIdAsync(string id);
    public ValueTask<IEnumerable<Student>> GetAllAsync();
    T Map<T>(Bogcha.Infrastructure.Services.StudentServices.StudensDtos.CreateStudentsDto viewEmployeeDto);
}
