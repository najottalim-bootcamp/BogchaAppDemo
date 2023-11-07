using System.Collections.Generic;

namespace Bogcha.DataAccess.Repositories.ImmunizationRecordRepositories
{
    public class ImmunizationRecordRepository : Database, IImmunizationRecordRepository
    {
        public ImmunizationRecordRepository(string connectionString) : base(connectionString) { }

        public async ValueTask<bool> CreateAsync(ImmunizationRecord immunizationRecord)
        {
            try
            {
                await sqlConnection.OpenAsync();
                string sqlQuery = "Insert into ImmunizationRecord values(@ChId," +
                    "@Chickenpox,@Diphtheria_Tetanus_WhoopingCough,@Haemophilus_influenza_typeB," +
                "@Hepatsis_A,@Hepatsis_B,@Influenza,@Measles,@Meningococcal,@Pneumococcal,@Polio,@Rotavirus)";

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
        public async ValueTask<bool> DeleteAsync(int Id)
        {
            try
            {
                await sqlConnection.OpenAsync();
                string sqlQuery = "Delete from ImmunizationRecord where Id=@Id";
                var command = new SqlCommand(sqlQuery, sqlConnection);
                command.Parameters.AddWithValue("@Id", Id);

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
    public async ValueTask<IEnumerable<ImmunizationRecord>> GetAllAsync()
    {
        try
        {
            await sqlConnection.OpenAsync();
            string sqlQuery = "Select * from ImmunizationRecord;";
            IEnumerable<ImmunizationRecord> immunizationRecord = await sqlConnection.QueryAsync<ImmunizationRecord>(sqlQuery);
            return immunizationRecord;
        }
        catch (Exception ex)
        {
            return Enumerable.Empty<ImmunizationRecord>();
        }
        finally
        {
            await sqlConnection.CloseAsync();
        }
    }

        public async ValueTask<ImmunizationRecord> GetByIdAsync(int Id)
        {
            try
            {
                await sqlConnection.OpenAsync();
                string sqlQuery = $"Select * from ImmunizationRecord where ChId=@Id;";

                ImmunizationRecord immunizationRecord = await sqlConnection.QueryFirstOrDefaultAsync<ImmunizationRecord>(sqlQuery, new { Id });

                return immunizationRecord;
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

        public async ValueTask<bool> UpdateAsync(ImmunizationRecord immunizationRecord)
        {
            try
            {
                await sqlConnection.OpenAsync();
                string sqlQuery = $"update ImmunizationRecord set " +
                    "ChId = @ChId, " +
                    "Chickenpox = @Chickenpox,gender = @Diphtheria_Tetanus_WhoopingCough,Passport = @Diphtheria_Tetanus_WhoopingCough," +
                    "Haemophilus_influenza_typeB = @Haemophilus_influenza_typeB,Hepatsis_A = @Hepatsis_A,Hepatsis_B = @Hepatsis_B,Influenza = @Influenza,Measles = @Measles, Meningococcal = @Meningococcal, Pneumococcal = @Pneumococcal, Polio = @Polio, Rotavirus = @Rotavirus " +
                    "where ChId=@chId";

                int result = await sqlConnection.ExecuteAsync(sqlQuery, immunizationRecord);

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
