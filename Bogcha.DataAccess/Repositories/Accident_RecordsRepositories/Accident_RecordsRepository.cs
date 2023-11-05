﻿namespace Bogcha.DataAccess.Repositories.Accident_RecordsRepositories
{
    public class Accident_RecordsRepository : Database, IAccident_RecordsRepository
    {
        public Accident_RecordsRepository(string connectionString) : base(connectionString)
        {
        }

        public async ValueTask<bool> CreateAsync(Accident_Records accident_Records)
        {

            try
            {
                await sqlConnection.OpenAsync();
                string sqlQuery = $"Insert into Accident_Records values({accident_Records.AccNo}, " +
                    $"'{accident_Records.ChId}', '{accident_Records.AccidentDate}'," +
                    $" '{accident_Records.TypeOfAccident}','{accident_Records.Location}','{accident_Records.FirstAid}')";

                var command = new SqlCommand(sqlQuery,sqlConnection);
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
                string sqlQuery = "Delete from Accident_Records where AccNo = @Id";

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

        public async ValueTask<IEnumerable<Accident_Records>> GetAllAsync()
        {
            try
            {
                await sqlConnection.OpenAsync();
                string sqlQuery = "Select * from Accident_Records;";
                IEnumerable<Accident_Records> accident_Records = await sqlConnection.QueryAsync<Accident_Records>(sqlQuery);
                return accident_Records;
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<Accident_Records>();
            }
            finally
            {
                await sqlConnection.CloseAsync();
            }
        }

        public async ValueTask<Accident_Records> GetByIdAsync(int id)
        {
            try
            {
                await sqlConnection.OpenAsync();
                string sqlQuery = $"Select * from Accident_Records where '{id}' = AccNo;";

                Accident_Records accident_Records = await sqlConnection.QueryFirstAsync<Accident_Records>(sqlQuery);

                return accident_Records;
            }
            catch (Exception ex)
            {
                return new Accident_Records();
            }
            finally
            {
                await sqlConnection.CloseAsync();
            }
        }

        public async ValueTask<bool> UpdateAsync(int id, Accident_Records accident_Records)
        {
            try
            {
                await sqlConnection.OpenAsync();
                string sqlQuery = $"update Accident_Records set @AccNo='{accident_Records.AccNo}', " +
                    $"@ChId = '{accident_Records.ChId}', @AccidentDate = '{accident_Records.AccidentDate}'," +
                    $"@TypeOfAccident='{accident_Records.TypeOfAccident}',@Location='{accident_Records.Location}'," +
                    $"@FirstAid='{accident_Records.FirstAid}' where '{id}' = AccNo;";

                var command = new SqlCommand(sqlQuery,sqlConnection);

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
    }
}