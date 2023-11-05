namespace Bogcha.DataAccess.Repositories.ClassInfoRepositories
{
    public class ClassInfoRepository : Database, IClassInfoRepository
    {
        public ClassInfoRepository(string connectionString) : base(connectionString) { }

        public async ValueTask<bool> CreateAsync(ClassInfo classInfo)
        {
            try
            {
                await sqlConnection.OpenAsync();
                string sqlQuery = "Insert into ClassInfo values(@ClassId,@ClassName," +
                    "@AgeGroup,@RoomNo,@HeadTeacher," +
                    "@AssistantTeacher)";

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
                string sqlQuery = "Delete from ClassInfo where id==Id";
                var command = new SqlCommand(sqlQuery, sqlConnection);
                command.Parameters.AddWithValue("Id", id);

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
        public async ValueTask<IEnumerable<ClassInfo>> GetAllAsync()
        {
            try
            {
                await sqlConnection.OpenAsync();
                string sqlQuery = "Select * from ClassInfo;";
                IEnumerable<ClassInfo> classInfo = await sqlConnection.QueryAsync<ClassInfo>(sqlQuery);
                return classInfo;
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<ClassInfo>();
            }
            finally
            {
                await sqlConnection.CloseAsync();
            }
        }

        public ValueTask<bool> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> UpdateAsync(int id, ClassInfo classInfo)
        {
            throw new NotImplementedException();
        }
    }
}

