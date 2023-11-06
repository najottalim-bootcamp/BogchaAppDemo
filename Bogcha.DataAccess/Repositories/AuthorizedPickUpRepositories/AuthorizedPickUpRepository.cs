namespace Bogcha.DataAccess.Repositories.AuthorizedPickUpRepositories
{
    public class AuthorizedPickUpRepository : Database, IAuthorizedPickUpRepository
    {
        public AuthorizedPickUpRepository(string connectionString) : base(connectionString) { }

        public async ValueTask<bool> CreateAsync(AuthorizedPickUp authorizedPickUp)
        {
            try
            {
                await sqlConnection.OpenAsync();
                string sqlQuery = "Insert into AuthorizedPickUp values(@ChId,@AuthFName," +
                    "@AuthLName,@gender,@Passport," +
                    "@strAddress,@city,@region,@zipCode,@phoneNo)";

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
        public async ValueTask<bool> DeleteAsync(string ChId)
        {
            try
            {
                await sqlConnection.OpenAsync();
                string sqlQuery = "Delete from AuthorizedPickUp where ChId==Id";
                var command = new SqlCommand(sqlQuery, sqlConnection);
                command.Parameters.AddWithValue("Id", ChId);

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
        public async ValueTask<IEnumerable<AuthorizedPickUp>> GetAllAsync()
        {
            try
            {
                await sqlConnection.OpenAsync();
                string sqlQuery = "Select * from AuthorizedPickUp;";
                IEnumerable<AuthorizedPickUp> authorizedPickUp = await sqlConnection.QueryAsync<AuthorizedPickUp>(sqlQuery);
                return authorizedPickUp;
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<AuthorizedPickUp>();
            }
            finally
            {
                await sqlConnection.CloseAsync();
            }
        }

        public ValueTask<AuthorizedPickUp> GetByIdAsync(string ChId)
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> UpdateAsync(string ChId, AuthorizedPickUp authorizedPickUp)
        {
            throw new NotImplementedException();
        }
    }
}

