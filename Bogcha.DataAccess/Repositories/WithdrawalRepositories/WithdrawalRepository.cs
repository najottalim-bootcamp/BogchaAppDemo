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
            await Console.Out.WriteLineAsync(ex.Message);
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
            await Console.Out.WriteLineAsync(ex.Message);
            return Enumerable.Empty<Withdrawal>();
        }
        finally
        {
            await sqlConnection.CloseAsync();
        }
    }

    public async ValueTask<Withdrawal> GetByIdAsync(int id)
    {
        try
        {
            await sqlConnection.OpenAsync();
            string sqlQuery = "Select * from Withdrawal where id = @Id";

            Withdrawal withdrawal = await sqlConnection.QueryFirstOrDefaultAsync<Withdrawal>(sqlQuery, new { Id = id });
            return withdrawal;
        }
        catch (Exception ex)
        {
            await Console.Out.WriteLineAsync(ex.Message);
            return null;
        }
        finally { await sqlConnection.CloseAsync(); }

    }

    public async ValueTask<bool> UpdateAsync(Withdrawal withdrawal)
    {
        try
        {
            await sqlConnection.OpenAsync();
            string sqlQuery = "Update Withdrawal set Expense = @Expense, Amount = @Amount, DatePaid = @DatePaid, WithDrawnBy = @WithDrawnBy where Id = @Id";

            int result = await sqlConnection.ExecuteAsync(sqlQuery, withdrawal);
            return result > 0;
        }
        catch (Exception ex)
        {
            await Console.Out.WriteLineAsync(ex.Message);
            return false;
        }
    }
}
