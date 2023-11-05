namespace Bogcha.DataAccess.Repositories.MealPlanRepositories;

public class MealPlanRepository : Database, IMealPlanRepository
{
    public MealPlanRepository(string connectionString) : base(connectionString) { }

    public async ValueTask<bool> CreateAsync(MealPlan mealPlan)
    {
        try
        {
            await sqlConnection.OpenAsync();
            string sqlQuery = "INSERT INTO MealPlan " +
                              "VALUES (@DateName, @MealNo, @AM_Snack, @Lunch, @Fruit, @PM_Snack)";

            int result = await sqlConnection.ExecuteAsync(sqlQuery, mealPlan);
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

    public async ValueTask<bool> DeleteAsync(string MealNo)
    {
        try
        {
            await sqlConnection.OpenAsync();
            string sqlQuery = "DELETE FROM MealPlan WHERE MealNo = @MealNo";

            int result = await sqlConnection.ExecuteAsync(sqlQuery, new { MealNo });
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

    public async ValueTask<IEnumerable<MealPlan>> GetAllAsync()
    {
        try
        {
            await sqlConnection.OpenAsync();
            string sqlQuery = "SELECT * FROM MealPlan";

            IEnumerable<MealPlan> mealPlans = await sqlConnection.QueryAsync<MealPlan>(sqlQuery);
            return mealPlans;
        }
        catch (Exception ex)
        {
            await Console.Out.WriteLineAsync(ex.Message);
            return Enumerable.Empty<MealPlan>();
        }
        finally
        {
            await sqlConnection.CloseAsync();
        }
    }

    public async ValueTask<MealPlan> GetByIdAsync(string MealNo)
    {
        try
        {
            await sqlConnection.OpenAsync();
            string sqlQuery = "SELECT * FROM MealPlan WHERE MealNo = @MealNo";

            MealPlan mealPlan = await sqlConnection.QueryFirstOrDefaultAsync<MealPlan>(sqlQuery, new { MealNo });
            return mealPlan;
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

    public async ValueTask<bool> UpdateAsync(MealPlan mealPlan)
    {
        try
        {
            await sqlConnection.OpenAsync();
            string sqlQuery = "UPDATE MealPlan " +
                              "SET DateName = @DateName, AM_Snack = @AM_Snack, Lunch = @Lunch, Fruit = @Fruit, PM_Snack = @PM_Snack " +
                              "WHERE MealNo = @MealNo";

            var result = await sqlConnection.ExecuteAsync(sqlQuery, mealPlan);
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

