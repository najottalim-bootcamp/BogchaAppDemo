namespace Bogcha.DataAccess.Repositories.Accident_RecordsRepositories;

public class Accident_RecordsRepository : Database, IAccident_RecordsRepository
{
    public Accident_RecordsRepository(string connectionString) : base(connectionString)
    {
    }

    public async ValueTask<bool> CreateAsync(AccidentRecords accident_Records)
    {

        try
        {
            await sqlConnection.OpenAsync();
            string sqlQuery = $"Insert into Accident_Records values(@AccNo, " +
                $"@ChId, @AccidentDate,@TypeOfAccident,@Location,@FirstAid)";

            int result = await sqlConnection.ExecuteAsync(sqlQuery, accident_Records);
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
            string sqlQuery = "Delete from Accident_Records where AccNo = @Id";

            var command = new SqlCommand(sqlQuery, sqlConnection);
            command.Parameters.AddWithValue("@Id", id);

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

    public async ValueTask<IEnumerable<AccidentRecords>> GetAllAsync()
    {
        try
        {
            await sqlConnection.OpenAsync();
            string sqlQuery = "Select * from Accident_Records;";
            IEnumerable<AccidentRecords> accident_Records = await sqlConnection.QueryAsync<AccidentRecords>(sqlQuery);
            return accident_Records;
        }
        catch (Exception ex)
        {
            return Enumerable.Empty<AccidentRecords>();
        }
        finally
        {
            await sqlConnection.CloseAsync();
        }
    }

    public async ValueTask<AccidentRecords> GetByIdAsync(int id)
    {
        try
        {
            await sqlConnection.OpenAsync();
            string sqlQuery = $"Select * from Accident_Records where AccNo=@id;";

            AccidentRecords accident_Records = await sqlConnection.QueryFirstOrDefaultAsync<AccidentRecords>(sqlQuery, new { id });

            return accident_Records;
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

    public async ValueTask<bool> UpdateAsync(AccidentRecords accident_Records)
    {
        try
        {
            await sqlConnection.OpenAsync();
            string sqlQuery = $"update Accident_Records set " +
                $"ChId=@ChId ,AccidentDate= @AccidentDate," +
                $"TypeOfAccident = @TypeOfAccident,Location =  @Location," +
                $"FirstAid=@FirstAid where AccNo=@AccNo;";

            int result = await sqlConnection.ExecuteAsync(sqlQuery, accident_Records);

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
}
