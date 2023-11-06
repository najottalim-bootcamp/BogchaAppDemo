using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogcha.DataAccess.Repositories.ActivityManagementRepositories
{
    public class ActivityManagementRepository : Database, IActivityManagementRepository
    {
        public ActivityManagementRepository(string connectionString) : base(connectionString)
        {
        }

        public async ValueTask<bool> CreateAsync(ActivityManagement activityManagement)
        {

            try
            {
                await sqlConnection.OpenAsync();
                string sqlQuery = $"Insert into ActivityManagement values(@Time, " +
                    $"@Task,@Led_by) SELECT CAST(SCOPE_IDENTITY() as int)";

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

        public async ValueTask<bool> DeleteAsync(int id)
        {
            try
            {
                await sqlConnection.OpenAsync();
                string sqlQuery = "Delete from ActivityManagement where Id = @Id";

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

                ActivityManagement activityManagement = await sqlConnection.QueryFirstOrDefaultAsync<ActivityManagement>(sqlQuery,new { id } );

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
                string sqlQuery = "update ActivityManagement set  " +
                    "Time=@Time , Task = @Task, " +
                    "Led_by=@Led_by " +
                    "where Id=@Id;";

                int result = await sqlConnection.ExecuteAsync(sqlQuery,  activityManagement);

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
