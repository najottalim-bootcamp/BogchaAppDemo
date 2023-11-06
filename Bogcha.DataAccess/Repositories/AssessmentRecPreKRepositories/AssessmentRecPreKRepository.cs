namespace Bogcha.DataAccess.Repositories.AssessmentRecPreKRepositories;

public class AssessmentRecPreKRepository : Database, IAssessmentRecPreKRepository
{
    public AssessmentRecPreKRepository(string connectionString) : base(connectionString) { }

    public async ValueTask<bool> CreateAsync(AssessmentRecPreK assessmentRecPreK)
    {
        try
        {
            await sqlConnection.OpenAsync();
            string sqlQuery = "Insert into AssessmentRecPreK values(@ChId,@ClassId," +
                "@AssessmentDate,@Alphabet_assessment_50,@Math_assessment_50," +
                "@Team_work_50,@Scissor_skills_50,@pattern_assessment_50,@Name_writing_50)";

            int result = await sqlConnection.ExecuteAsync(sqlQuery, assessmentRecPreK);
            return result > 0;
        }
        catch (Exception ex)
        {
            return false;
        }
        finally
        {
            await sqlConnection.CloseAsync();
        }
    }
    public async ValueTask<bool> DeleteAsync(int id)
    {
        try
        {
            await sqlConnection.OpenAsync();
            string sqlQuery = "Delete from AssessmentRecPreK where Id=@id";
            var command = new SqlCommand(sqlQuery, sqlConnection);
            command.Parameters.AddWithValue("Id", id);

            int result = await command.ExecuteNonQueryAsync();
            return result > 0;
        }
        catch
        {
            return false;
        }
        finally
        {
            await sqlConnection.CloseAsync();
        }
    }
    public async ValueTask<IEnumerable<AssessmentRecPreK>> GetAllAsync()
    {
        try
        {
            await sqlConnection.OpenAsync();
            string sqlQuery = "Select * from AssessmentRecPreK;";
            IEnumerable<AssessmentRecPreK> assessmentRecPreK = await sqlConnection.QueryAsync<AssessmentRecPreK>(sqlQuery);
            return assessmentRecPreK;
        }
        catch (Exception ex)
        {
            return Enumerable.Empty<AssessmentRecPreK>();
        }
        finally
        {
            await sqlConnection.CloseAsync();
        }
    }

    public async ValueTask<AssessmentRecPreK> GetByIdAsync(int id)
    {
        try
        {
            await sqlConnection.OpenAsync();
            string sqlQuery = "Select * from AssessmentRecPreK where Id=@id";
            AssessmentRecPreK assessmentRecPreK = await sqlConnection.QueryFirstOrDefaultAsync<AssessmentRecPreK>(sqlQuery, new { Id = id });
            return assessmentRecPreK;
        }
        catch (Exception ex)
        {
            await Console.Out.WriteLineAsync(ex.Message);
            return null;
        }
        finally { await sqlConnection.CloseAsync(); }
    }

    public async ValueTask<bool> UpdateAsync(int id, AssessmentRecPreK assessmentRecPreK)
    {
        try
        {
            await sqlConnection.OpenAsync();
            string sqlQuery = "Update AssessmentRecPreK " +
            "Set AssessmentDate=@AssessmentDate,Alphabet_assessment_50=@Alphabet_assessment_50," +
            "Math_assessment_50=@Math_assessment_50,Team_work_50=@Team_work_50,Scissor_skills_50=@Scissor_skills_50," +
            "patteren_assessment_50=@patteren_assessment_50,Name_writing_50=@Name_writing_50 " +
            "where Id=@Id";
            var result = await sqlConnection.ExecuteAsync(sqlQuery, assessmentRecPreK );
            return result > 0;

        }
        catch (Exception ex)
        {
            await Console.Out.WriteLineAsync(ex.Message);
            return false;
        }
        finally { await sqlConnection.CloseAsync(); }
    }
}


