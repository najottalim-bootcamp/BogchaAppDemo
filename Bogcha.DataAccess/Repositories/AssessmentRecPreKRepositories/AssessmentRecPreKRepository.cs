using Bogcha.Domain.Entities;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogcha.DataAccess.Repositories.AssessmentRecPreKRepositories
{
    public class AssessmentRecPreKRepository:Database,IAssessmentRecPreKRepository
    {
        public AssessmentRecPreKRepository(string connectionString) : base(connectionString) { }

        public async ValueTask<bool> CreateAsync(AssessmentRecPreK assessmentRecKG)
        {
            try
            {
                await sqlConnection.OpenAsync();
                string sqlQuery = "Insert into AssessmentRecPreK values(@ChId,@ClassId," +
                    "@AssessmentDate,@Alphabet_assessment_50,@Math_assessment_50," +
                    "@Team_work_50,@Scissor_skill_50,@pattern_assessment_50,@Name_writing_50)";

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
                string sqlQuery = "Delete from AssessmentRecPreK where id==Id";
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
        public async ValueTask<IEnumerable<AssessmentRecPreK>> GetAllAsync()
        {
            try
            {
                await sqlConnection.OpenAsync();
                string sqlQuery = "Select * from AssessmentRecPreK;";
                IEnumerable<AssessmentRecPreK> assessmentRecKGs = await sqlConnection.QueryAsync<AssessmentRecPreK>(sqlQuery);
                return assessmentRecKGs;
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<AssessmentRecPreK>();
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

        public ValueTask<bool> UpdateAsync(int id, AssessmentRecPreK assessmentRecKG)
        {
            throw new NotImplementedException();
        }
    }
}
