namespace Bogcha.DataAccess.Repositories.AttendanceRepositories
{
    public class AttendanceRepository : Database
    {
        public AttendanceRepository(string connectionString) : base(connectionString) { }
        public async ValueTask<bool> CreateAsync(Attendance attendance)
        {

            try
            {
                await sqlConnection.OpenAsync();
                string sqlQuery = $"Insert into Accident_Records values(@Time, " +
                    $"@Task,@Led_by)";

                int result = await sqlConnection.ExecuteAsync(sqlQuery, attendance);
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
                string sqlQuery = "Delete from Accident_Records where Id = @Id";

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

        public async ValueTask<IEnumerable<ActivityManagement>> GetAllAsync()
        {
            try
            {
                await sqlConnection.OpenAsync();
                string sqlQuery = "Select * from ActivityManagement;";
                IEnumerable<ActivityManagement> activityManagements = await sqlConnection.QueryAsync<ActivityManagement>(sqlQuery);
                return activityManagements;
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<ActivityManagement>();
            }
            finally
            {
                await sqlConnection.CloseAsync();
            }
        }

        public async ValueTask<ActivityManagement> GetByIdAsync(int id)
        {
            try
            {
                await sqlConnection.OpenAsync();
                string sqlQuery = $"Select * from ActivityManagement where Id=@id;";

                ActivityManagement activityManagement = await sqlConnection.QueryFirstOrDefaultAsync<ActivityManagement>(sqlQuery, new { id });

                return activityManagement;
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

        public async ValueTask<bool> UpdateAsync(ActivityManagement activityManagement)
        {
            try
            {
                await sqlConnection.OpenAsync();
                string sqlQuery = $"update Accident_Records set  " +
                    $"Time=@Time , Task = @Task" +
                    $"Led_by=@Led_by" +
                    $"where id=@id;";

                int result = await sqlConnection.ExecuteAsync(sqlQuery, activityManagement);

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
}
