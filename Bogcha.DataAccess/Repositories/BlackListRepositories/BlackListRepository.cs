namespace Bogcha.DataAccess.Repositories.BlackListRepositories
{
    public class BlackListRepository : Database, IBlackListRepository
    {
        public BlackListRepository(string connectionString) : base(connectionString) { }

        public async ValueTask<bool> CreateAsync(BlackList blackList)
        {
            try
            {
                await sqlConnection.OpenAsync();
                string sqlQuery = "Insert into BlackList values(@ChId,@UnauthFName," +
                    "@UnauthLName,@gender,@Passport," +
                    "@strAddress,@city,@state,@zipCode,@phoneNo)";

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
                string sqlQuery = "Delete from BlackList where id==Id";
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
        public async ValueTask<IEnumerable<BlackList>> GetAllAsync()
        {
            try
            {
                await sqlConnection.OpenAsync();
                string sqlQuery = "Select * from BlackList;";
                IEnumerable<BlackList> blackList = await sqlConnection.QueryAsync<BlackList>(sqlQuery);
                return blackList;
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<BlackList>();
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

        public ValueTask<bool> UpdateAsync(int id, BlackList blackList)
        {
            throw new NotImplementedException();
        }
    }
}
