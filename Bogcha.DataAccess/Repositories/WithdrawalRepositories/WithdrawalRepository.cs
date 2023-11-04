using Bogcha.Domain.Entities;
using Dapper;
using System.Data.SqlClient;

namespace Bogcha.DataAccess.Repositories.WithdrawalRepositories;

public class WithdrawalRepository : Database, IWithdrawalRepository
{
    public WithdrawalRepository(string connectionString) : base(connectionString) { }

    public async ValueTask<bool> CreateAsync(Withdrawal withdrawal)
    {
        try
        {
            await sqlConnection.OpenAsync();
            string sqlQuery = "Insert into Withdrawal values(@Expense, @Amount, @DatePaid, @withdrawnBy); SELECT CAST(SCOPE_IDENTITY() as int)";
            
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
            string sqlQuery = "Delete from Withdrawal where id = @Id";

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

    public async ValueTask<IEnumerable<Withdrawal>> GetAllAsync()
    {
        try
        {
            await sqlConnection.OpenAsync();
            string sqlQuery = "Select * from Withdrawal;";
            IEnumerable<Withdrawal> withdrawals = await sqlConnection.QueryAsync<Withdrawal>(sqlQuery);
            return withdrawals;
        }
        catch (Exception ex)
        {
            return Enumerable.Empty<Withdrawal>();
        }
        finally
        {
            await sqlConnection.CloseAsync();
        }
    }

    public ValueTask<Withdrawal> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> UpdateAsync(int id, Withdrawal withdrawal)
    {
        throw new NotImplementedException();
    }
}
