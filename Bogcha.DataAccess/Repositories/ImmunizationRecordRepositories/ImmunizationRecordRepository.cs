namespace Bogcha.DataAccess.Repositories.ImmunizationRecordRepositories;

public class ImmunizationRecordRepository : Database, IImmunizationRecordRepository
{
    public ImmunizationRecordRepository(string connectionString) : base(connectionString) { }

    public async ValueTask<bool> CreateAsync(ImmunizationRecord immunizationRecord)
    {
        try
        {
            await sqlConnection.OpenAsync();
            string sqlQuery = "Insert into ImmunizationRecord values(@Id,@ChId," +
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
    public async ValueTask<bool> DeleteAsync(int id)
    {
        try
        {
            await sqlConnection.OpenAsync();
            string sqlQuery = "Delete from ImmunizationRecord where id==Id";
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

    public ValueTask<bool> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> UpdateAsync(int id, ImmunizationRecord immunizationRecord)
    {
        throw new NotImplementedException();
    }
}
