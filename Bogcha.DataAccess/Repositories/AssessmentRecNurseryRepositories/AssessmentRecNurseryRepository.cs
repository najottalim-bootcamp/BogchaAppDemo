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

            var command = new SqlCommand(sqlQuery, sqlConnection);
            int result = await command.ExecuteNonQueryAsync();
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
            string sqlQuery = "Delete from AssessmentRecNursery where id==Id";
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
            string sqlQuery = "Select * from AssessmentRecKG;";
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

    public ValueTask<bool> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> UpdateAsync(int id, AssessmentRecNursery assessmentRecnursery)
    {
        throw new NotImplementedException();
    }
}
