namespace Bogcha.DataAccess.Repositories.RegularHealthCheckRepositories;

public class RegularHealthCheckRepository:Database,IRegularHealthCheckRepository
{

    

    public RegularHealthCheckRepository(string connectionString) : base(connectionString) { }


    public async ValueTask<bool> CreateAsync(RegularHealthCheck regularHealthCheck)

    {

            try
            {
                await sqlConnection.OpenAsync();
                string sqlQuery = "Insert into RegularHealthCheck values(" +
                    "@ChId,@checKupDate,@Symptom,@ActionRequired) SELECT CAST(SCOPE_IDENTITY() as int)";

                int result = await sqlConnection.ExecuteAsync(sqlQuery, regularHealthCheck);
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
            string sqlQuery = "Delete from RegularHealthCheck where Id = @Id";

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

    public async ValueTask<IEnumerable<RegularHealthCheck>> GetAllAsync()
    {
        try
        {
            await sqlConnection.OpenAsync();
            string sqlQuery = "Select * from RegularHealthCheck;";
            IEnumerable<RegularHealthCheck> regularHealthChecks = await sqlConnection.QueryAsync<RegularHealthCheck>(sqlQuery);
            return regularHealthChecks;
        }
        catch (Exception ex)
        {
            return Enumerable.Empty<RegularHealthCheck>();
        }
        finally
        {
            await sqlConnection.CloseAsync();
        }
    }

    public async ValueTask<RegularHealthCheck> GetByIdAsync(int id)
    {

            try
            {
                await sqlConnection.OpenAsync();
                string sqlQuery = "Select * from RegularHealthCheck where Id=@id;";

                RegularHealthCheck regularHealthCheck = await sqlConnection.QueryFirstOrDefaultAsync<RegularHealthCheck>(sqlQuery, new { id });

                return regularHealthCheck;
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

    public async ValueTask<bool> UpdateAsync(RegularHealthCheck regularHealthCheck)
    {
     
            try
            {
                await sqlConnection.OpenAsync();
                string sqlQuery = "update RegularHealthCheck set  " +
                    "ChId=@ChId,checKupDate=@checKupDate,Symptom=@Symptom,ActionRequired = @ActionRequired " +
                    "where Id=@Id;";

                int result = await sqlConnection.ExecuteAsync(sqlQuery, regularHealthCheck);

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
