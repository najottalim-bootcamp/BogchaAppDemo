namespace Bogcha.DataAccess.Repositories.StudentRepositories;

public class StudentRepository : Database, IStudentRepository
{
    public StudentRepository(string connectionString) : base(connectionString)
    {
    }

    public async ValueTask<bool> CreateAsync(Student entity)
    {
        try
        {
            await sqlConnection.OpenAsync();

            string Query = "Insert into Student values(@CHId,@ChFName,@ChLName,@Gender," +
                "@ChDoB,@RegisteredDate,@EnrollmentDate,@StAddress,@City,@Region,@ZipCode," +
                "@PhyImpairment,@AllergyType,@AllergySymptom)";

            int result = await sqlConnection.ExecuteAsync(Query, entity);
            return result > 0;
        }
        catch (Exception ex)
        {
            await Console.Out.WriteLineAsync(ex.Message);
            return false;
        }
        finally
        {
            await sqlConnection.CloseAsync();
        }
    }

    public async ValueTask<bool> DeleteAsync(string id)
    {
        try
        {
            await sqlConnection.OpenAsync();
            string Query = "Delete from Student where CHId =@id";

            var command = new SqlCommand(Query, sqlConnection);
            command.Parameters.AddWithValue("@id", id);

            int result = await command.ExecuteNonQueryAsync();
            return result > 0;
        }
        catch (Exception ex)
        {
            await Console.Out.WriteLineAsync(ex.Message);
            return false;
        }
        finally
        {
            await sqlConnection.CloseAsync();
        }
    }

    public async ValueTask<IEnumerable<Student>> GetAllAsync()
    {
        try
        {
            await sqlConnection.OpenAsync();
            string Query = "Select * from Student";

            IEnumerable<Student> student = await sqlConnection.QueryAsync<Student>(Query);
            return student;
        }
        catch (Exception ex)
        {
            await Console.Out.WriteLineAsync(ex.Message);
            return Enumerable.Empty<Student>();
        }
        finally
        {
            await sqlConnection.CloseAsync();
        }
    }

    public async ValueTask<Student> GetByIdAsync(string id)
    {
        try
        {
            await sqlConnection.OpenAsync();
            string Query = "Select * from Student Where CHId = @id ";

            Student student = await sqlConnection.QueryFirstOrDefaultAsync<Student>(Query, new { id = id });
            return student;
        }
        catch (Exception ex)
        {
            await Console.Out.WriteLineAsync(ex.Message);
            return null;
        }
        finally
        {
            await sqlConnection.CloseAsync();
        }
    }

    public async ValueTask<bool> UpdateAsync(Student entity)
    {
        try
        {
            await sqlConnection.OpenAsync();
            string Query = "Update Student set " +
                "ChFName=@ChFName,ChLName=@ChLName,Gender=@Gender," +
                "ChDoB=@ChDoB,RegisteredDate=@RegisteredDate,EnrollmentDate=@EnrollmentDate," +
                "StAddress=@StAddress,City=@City,Region=@Region,ZipCode=@ZipCode," +
                "PhyImpairment=@PhyImpairment,AllergyType=@AllergyType,AllergySymptom=@AllergySymptom" +
                " where CHId =@CHId ";

            int result = await sqlConnection.ExecuteAsync(Query, entity);
            return result > 0;

        }
        catch (Exception ex)
        {
            await Console.Out.WriteLineAsync(ex.Message);
            return false;
        }
        finally
        {
            await sqlConnection.CloseAsync();
        }
    }
}








