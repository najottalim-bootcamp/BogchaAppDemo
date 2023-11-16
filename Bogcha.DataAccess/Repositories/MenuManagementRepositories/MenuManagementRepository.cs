namespace Bogcha.DataAccess.Repositories.MenuManagementRepositories;

public class MenuManagementRepository : Database, IMenuManagementRepository
{
    public MenuManagementRepository(string connectionString) : base(connectionString) { }

    public async ValueTask<bool> CreateAsync(MenuManagement menuManagement)
    {
        try
        {
            await sqlConnection.OpenAsync();
            string sqlQuery = "INSERT INTO MenuManagements VALUES" +
                              "(@ChId, @Monday, @Tuesday, @Wednesday, @Thursday, @Friday)";

            int result = await sqlConnection.ExecuteAsync(sqlQuery, menuManagement);
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

    public async ValueTask<bool> DeleteAsync(string ChId)
    {
        try
        {
            await sqlConnection.OpenAsync();
            string sqlQuery = "DELETE FROM MenuManagements WHERE ChId = @ChId";

            int result = await sqlConnection.ExecuteAsync(sqlQuery, new { ChId });
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

    public async ValueTask<IEnumerable<MenuManagement>> GetAllAsync()
    {
        try
        {
            await sqlConnection.OpenAsync();
            string sqlQuery = "SELECT * FROM MenuManagements";

            IEnumerable<MenuManagement> menuManagements = await sqlConnection.QueryAsync<MenuManagement>(sqlQuery);
            return menuManagements;
        }
        catch (Exception ex)
        {
            await Console.Out.WriteLineAsync(ex.Message);
            return Enumerable.Empty<MenuManagement>();
        }
        finally
        {
            await sqlConnection.CloseAsync();
        }
    }

    public async ValueTask<MenuManagement> GetByIdAsync(string ChId)
    {
        try
        {
            await sqlConnection.OpenAsync();
            string sqlQuery = "SELECT * FROM MenuManagements WHERE ChId = @ChId";

            MenuManagement menuManagement = await sqlConnection.QueryFirstOrDefaultAsync<MenuManagement>(sqlQuery, new { ChId = ChId });
            return menuManagement;
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

    public async ValueTask<bool> UpdateAsync(MenuManagement menuManagement)
    {
        try
        {
            await sqlConnection.OpenAsync();
            string sqlQuery = "UPDATE MenuManagements " +
                              "SET Monday = @Monday, Tuesday = @Tuesday, Wednesday = @Wednesday, Thursday = @Thursday, Friday = @Friday " +
                              "WHERE ChId = @ChId";

            var result = await sqlConnection.ExecuteAsync(sqlQuery, menuManagement);
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