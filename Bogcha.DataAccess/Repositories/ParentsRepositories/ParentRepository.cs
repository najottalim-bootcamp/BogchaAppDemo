namespace Bogcha.DataAccess.Repositories.ParentsRepositories;

public class ParentRepository : Database, IParentRepository
{
    public ParentRepository(string connectionString) : base(connectionString) { }

    public async ValueTask<bool> CreateAsync(Parents entity)
    {
        try
        {
            await sqlConnection.OpenAsync();

            string Query = "Insert into Parents values(@ChId,@FatherFullName,@MotherFullName,@Passport," +
                "@StrAddress,@City,@Region,@ZipCode,@PhoneNo1,@PhoneNo2,@Email)";

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
            string Query = "Delete from Parents where ChId =@id";

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



    public async ValueTask<IEnumerable<Parents>> GetAllAsync()
    {
        try
        {
            await sqlConnection.OpenAsync();
            string Query = "Select * from Parents";

            IEnumerable<Parents> par = await sqlConnection.QueryAsync<Parents>(Query);
            return par;
        }
        catch (Exception ex)
        {
            await Console.Out.WriteLineAsync(ex.Message);
            return Enumerable.Empty<Parents>();
        }
        finally
        {

        }
    }



    public async ValueTask<Parents> GetByIdAsync(string id)
    {
        try
        {
            await sqlConnection.OpenAsync();
            string Query = "Select * from Parents Where ChId = @id ";

            Parents student = await sqlConnection.QueryFirstOrDefaultAsync<Parents>(Query, new { id = id });
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



    public async ValueTask<bool> UpdateAsync(Parents par)
    {
        try
        {
            await sqlConnection.OpenAsync();
            string Query = "Update Parents set " +
                "FatherFullName=@FatherFullName,MotherFullName=@MotherFullName," +
                "Passport=@Passport,StrAddress=@StrAddress,City=@City,Region=@Region," +
                "ZipCode=@ZipCode,PhoneNo1=@PhoneNo1,PhoneNo2=@PhoneNo2,Email=@Email " +
                "where ChId =@ChId ";

            int result = await sqlConnection.ExecuteAsync(Query, par);
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
