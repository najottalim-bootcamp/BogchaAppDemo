using Bogcha.Domain.Entities;
using Dapper;
using System.Data.SqlClient;

namespace Bogcha.DataAccess.Repositories.AssessmentRecKGRepositories;

public class AssessmentRecKGRepository:Database,IAssessmentRecKGRepository
{
    public AssessmentRecKGRepository(string connectionString) : base(connectionString) { }

    public async ValueTask<bool> CreateAsync(AssessmentRecKG assessmentRecKG)
    {
        try
        {
            await sqlConnection.OpenAsync();
            string sqlQuery = "Insert into AssessmentRecKG values(@ChId,@ClassId," +
                "@AssessmentDate,@Know_100,@Math_100,@Read_100,@Spell_100,@Camera_Reading_100," +
                "@Camera_spelling_100,@Sentence_assessment_100,@Pattern_assessment_100,@Name_writing_100)";

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
            string sqlQuery = "Delete from AssessmentRecKG where id==Id";
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
            await sqlConnection.CloseAsync() ;
        }
    }
    public async ValueTask<IEnumerable<AssessmentRecKG>>GetAllAsync()
    {
        try
        {
            await sqlConnection.OpenAsync();
            string sqlQuery = "Select * from AssessmentRecKG;";
            IEnumerable<AssessmentRecKG> assessmentRecKGs = await sqlConnection.QueryAsync<AssessmentRecKG>(sqlQuery);
            return assessmentRecKGs;
        }
        catch (Exception ex)
        {
            return Enumerable.Empty<AssessmentRecKG>();
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

    public ValueTask<bool> UpdateAsync(int id, AssessmentRecKG assessmentRecKG)
    {
        throw new NotImplementedException();
    }
}


