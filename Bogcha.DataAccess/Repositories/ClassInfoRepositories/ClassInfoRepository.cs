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
        public async ValueTask<bool> DeleteAsync(string id)
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

        public async ValueTask<ClassInfo> GetByIdAsync(string Id)
        {
            try
            {
                await sqlConnection.OpenAsync();
                string sqlQuery = $"Select * from ClassInfo where ChId=@Id;";

                ClassInfo classInfo = await sqlConnection.QueryFirstOrDefaultAsync<ClassInfo>(sqlQuery, new { Id });

                return classInfo;
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

        public async ValueTask<bool> UpdateAsync(ClassInfo classInfo)
        {
            try
            {
                await sqlConnection.OpenAsync();
                string sqlQuery = $"update ClassInfo set " +
                    "AuthFName = @AuthFName, " +
                    "AuthLName = @AuthLName,gender = @gender,Passport = @Passport," +
                    "strAddress = @strAddress,city = @city,region = @region,zipCode = @zipCode,phoneNo = @phoneNo " +
                    "where ChId=@chId";

                int result = await sqlConnection.ExecuteAsync(sqlQuery, classInfo);

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

