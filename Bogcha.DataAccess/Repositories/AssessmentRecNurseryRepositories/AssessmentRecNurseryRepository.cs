using Bogcha.Domain.Entities;
using Dapper;
using System.Data.SqlClient;

namespace Bogcha.DataAccess.Repositories.AssessmentRecNurseryRepositories;

public class AssessmentRecNurseryRepository : Database, IAssessmentRecNurseryRepository
{
    public AssessmentRecNurseryRepository(string connectionString) : base(connectionString) { }

    public async ValueTask<bool> CreateAsync(AssessmentRecNursery assessmentRecNursery)
    {
        try
        {
            await sqlConnection.OpenAsync();
            string sqlQuery = "Insert into AssessmentRecNursery values(@ChId,@ClassId," +
                "@AssessmentDate,@Reflection_5,@Social_development_5,@Emotional_development_5,@Conflict_resolution_5)";

            int result = await sqlConnection.ExecuteAsync(sqlQuery, assessmentRecNursery);
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
            string sqlQuery = "Delete from AssessmentRecNursery where Id=@id";
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
    public async ValueTask<IEnumerable<AssessmentRecNursery>> GetAllAsync()
    {
        try
        {
            await sqlConnection.OpenAsync();
            string sqlQuery = "Select * from AssessmentRecNursery;";
            IEnumerable<AssessmentRecNursery> assessmentRecKGs = await sqlConnection.QueryAsync<AssessmentRecNursery>(sqlQuery);
            return assessmentRecKGs;
        }
        catch (Exception ex)
        {
            return Enumerable.Empty<AssessmentRecNursery>();
        }
        finally
        {
            await sqlConnection.CloseAsync();
        }
    }

    public async ValueTask<AssessmentRecNursery> GetByIdAsync(int id)
    {
        try
        {
            await sqlConnection.OpenAsync();
            string sqlQuery = "Select * from AssessmentRecNursery where Id=@id";
            AssessmentRecNursery assessmentRecNursery = await sqlConnection.QueryFirstOrDefaultAsync<AssessmentRecNursery>(sqlQuery, new { Id = id });
            return assessmentRecNursery;
        }
        catch (Exception ex)
        {
            await Console.Out.WriteLineAsync(ex.Message);
            return null;
        }
        finally { await sqlConnection.CloseAsync(); }
    }

    public async ValueTask<bool> UpdateAsync(int id, AssessmentRecNursery assessmentRecNursery)
    {
        try
        {
            await sqlConnection.OpenAsync();
            string sqlQuery = "Update AssessmentRecNursery " +
                "Set AssessmentDate=@AssessmentDate,Reflection_5=@Reflection_5,Social_development_5=@Social_development_5," +
                "Emotional_development_5=@Emotional_development_5,Conflict_resolution_5=@Conflict_resolution_5 " +
                "Where Id=@Id";
            var result = await sqlConnection.ExecuteAsync(sqlQuery, assessmentRecNursery );
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
