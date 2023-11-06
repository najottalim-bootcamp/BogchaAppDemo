using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogcha.DataAccess.Repositories.AttendanceRepositories
{
    public class AttendanceRepository:Database,IAttendanceRepository
    {
        public AttendanceRepository(string connectionString) : base(connectionString){ }


        public async ValueTask<bool> CreateAsync(Attendance attendance)
        {

            try
            {
                await sqlConnection.OpenAsync();
                string sqlQuery = $"Insert into Attendance values( " +
                    $"@ChId,@SignIn_Time,@SignOut_Time) SELECT CAST(SCOPE_IDENTITY() as int)";

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
                string sqlQuery = "Delete from Attendance where Id = @Id";

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

        public async ValueTask<IEnumerable<Attendance>> GetAllAsync()
        {
            try
            {
                await sqlConnection.OpenAsync();
                string sqlQuery = "Select * from Attendance;";
                IEnumerable<Attendance> attendance = await sqlConnection.QueryAsync<Attendance>(sqlQuery);
                return attendance;
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<Attendance>();
            }
            finally
            {
                await sqlConnection.CloseAsync();
            }
        }

        public async ValueTask<Attendance> GetByIdAsync(int id)
        {
            try
            {
                await sqlConnection.OpenAsync();
                string sqlQuery = $"Select * from Attendance where Id=@id;";

                Attendance attendance = await sqlConnection.QueryFirstOrDefaultAsync<Attendance>(sqlQuery, new { id });

                return attendance;
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

        public async ValueTask<bool> UpdateAsync(Attendance activityManagement)
        {
            try
            {
                await sqlConnection.OpenAsync();
                string sqlQuery = "update Attendance set  " +
                    "Time=@Time , Task = @Task, " +
                    "Led_by=@Led_by " +
                    "where Id=@Id;";

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
