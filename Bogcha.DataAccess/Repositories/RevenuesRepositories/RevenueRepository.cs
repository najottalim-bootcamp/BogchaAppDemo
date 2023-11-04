namespace Bogcha.DataAccess.Repositories.RevenuesRepositories;

public class RevenueRepository : Database, IRevenueRepository
{
    public RevenueRepository(string connectionString) : base(connectionString) { }

    public async ValueTask<bool> CreateAsync(Revenue revenue)
    {
        try
        {
            await sqlConnection.OpenAsync();
            string sqlQuery = "INSERT INTO Revenue VALUES (@ChId, @RegistrationFee, @Term1, @Term2, @Term3, @Book, @InvoiceNo, @RecieptNo)";
            
            int result = await sqlConnection.ExecuteAsync(sqlQuery,revenue);
            return result > 0;
        }
        catch(Exception ex)
        {
            await Console.Out.WriteLineAsync(ex.Message);
            return false;
        }
        finally
        { await sqlConnection.CloseAsync(); }
    }

    public async ValueTask<bool> DeleteAsync(string ChId)
    {
        try
        {
            await sqlConnection.OpenAsync();
            string sqlQuery = "DELETE FROM Revenue WHERE ChId = @ChId";

            int result = await sqlConnection.ExecuteAsync(sqlQuery, new { ChId = ChId });
            return result > 0;
        }
        catch(Exception ex)
        {
            await Console.Out.WriteLineAsync(ex.Message);
            return false;
        }
        finally { await sqlConnection.CloseAsync(); }
    }

    public async ValueTask<IEnumerable<Revenue>> GetAllAsync()
    {
        try
        {
            await sqlConnection.OpenAsync();
            string sqlQuery = "SELECT * FROM Revenue";

            IEnumerable<Revenue> revenues = await sqlConnection.QueryAsync<Revenue>(sqlQuery);
            return revenues;
        }
        catch (Exception ex)
        {
            await Console.Out.WriteLineAsync(ex.Message);
            return Enumerable.Empty<Revenue>();
        }
        finally { sqlConnection.Close(); }

    }

    public async ValueTask<Revenue> GetByIdAsync(string ChId)
    {
        try
        {
            await sqlConnection.OpenAsync();
            string sqlQuery = "SELECT * FROM Revenue WHERE ChId = @ChId";

            Revenue revenue = await sqlConnection.QueryFirstOrDefaultAsync<Revenue>(sqlQuery, new {Id = ChId});
            return revenue;
        }
        catch (Exception ex)
        {
            await Console.Out.WriteLineAsync(ex.Message);
            return null;
        }
        finally { await sqlConnection.CloseAsync(); }
    }


    public async ValueTask<bool> UpdateAsync(Revenue revenue)
    {
        try
        {
            await sqlConnection.OpenAsync();
            string sqlQuery = "UPDATE Revenue " +
                                "SET RegistrationFee = @RegistrationFee, Term1 = @Term1, Term2 = @Term2, Term3 = @Term3, " +
                                "Book = @Book, InvoiceNo = @InvoiceNo, RecieptNo = @RecieptNo " +
                                "WHERE ChId = @ChId";

            var result = await sqlConnection.ExecuteAsync(sqlQuery, revenue);
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