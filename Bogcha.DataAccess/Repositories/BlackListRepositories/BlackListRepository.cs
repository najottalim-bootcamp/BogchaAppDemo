﻿namespace Bogcha.DataAccess.Repositories.BlackListRepositories
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
        public async ValueTask<bool> DeleteAsync(string ChId)
        {
            try
            {
                await sqlConnection.OpenAsync();
                string sqlQuery = "Delete from BlackList where ChId=@Id";
                var command = new SqlCommand(sqlQuery, sqlConnection);
                command.Parameters.AddWithValue("@Id", ChId);

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

        public async ValueTask<BlackList> GetByIdAsync(string ChId)
        {
            try
            {
                await sqlConnection.OpenAsync();
                string sqlQuery = $"Select * from BlackList where ChId=@ChId;";

                BlackList blackList = await sqlConnection.QueryFirstOrDefaultAsync<BlackList>(sqlQuery, new { ChId });

                return blackList;
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

        public async ValueTask<bool> UpdateAsync(BlackList blackList)
        {
            try
            {
                await sqlConnection.OpenAsync();
                string sqlQuery = $"update BlackList set " +
                    "UnauthAuthFName = @UnauthAuthFName, " +
                    "UnauthAuthLName = @UnauthAuthLName,gender = @gender,Passport = @Passport," +
                    "strAddress = @strAddress,city = @city,state= @state,zipCode = @zipCode,phoneNo = @phoneNo " +
                "where ChId=@chId";

                int result = await sqlConnection.ExecuteAsync(sqlQuery, blackList);

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
