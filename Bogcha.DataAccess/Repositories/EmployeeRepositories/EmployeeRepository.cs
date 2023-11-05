

namespace Bogcha.DataAccess.Repositories.EmployeeRepositories;

public class EmployeeRepository : Database, IEmployeeRepository
{
    public EmployeeRepository(string connectionString) : base(connectionString) { }

    public async ValueTask<bool> CreateAsync(Employee entity)
    {

        try
        {
            await sqlConnection.OpenAsync();

            string Query = "Insert into Employee values(@EmpId,@EmpFName,@EmpLName,@Passport," +
                "@DateTime,@Gender,@Salary,@EmployedDate,@StrAddress,@Apt,@City,@Region," +
                "@ZipCode,@PhoneNo,@Email,@EmpType,@Department);SELECT CAST(SCOPE_IDENTITY() as int)";

            var command = new SqlCommand(Query, sqlConnection);
            int  result = await command.ExecuteNonQueryAsync();
            return result > 0;
        }
        catch (Exception ex) 
        {
            await Console.Out.WriteLineAsync(ex.Message);
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
            string Query = "Delete from Employee where id =@EmpId";

            var command = new SqlCommand(Query ,sqlConnection);
            command.Parameters.AddWithValue("@EmpId", id);  

            int result = await command.ExecuteNonQueryAsync();  
            return result > 0;
        }
        catch(Exception ex) 
        {
            await Console.Out.WriteLineAsync (ex.Message);
            return false;
        }
        finally
        {
            await sqlConnection.CloseAsync();
        }

    }

    public async ValueTask<IEnumerable<Employee>> GetAllAsync()
    {
        try
        {
            await sqlConnection.OpenAsync();
            string Query = "Select * from Employee";

            IEnumerable<Employee> employees = await sqlConnection.QueryAsync<Employee>(Query);
            return employees;
        }
        catch(Exception ex)
        {
            await Console.Out.WriteLineAsync(ex.Message);
            return Enumerable.Empty<Employee>();
        }
        finally 
        { 
            await sqlConnection.CloseAsync(); 
        }   

    }

    public async ValueTask<Employee> GetByIdAsync(string id)
    {
        try
        {
            await sqlConnection.OpenAsync();
            string Query = "Select * from Employee Where Id = @EpmId ";

            Employee employee= await sqlConnection.QueryFirstOrDefaultAsync<Employee>(Query, new{ EmpId = id });
            return employee;
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

    public async ValueTask<bool> UpdateAsync(Employee entity)
    {
        try
        {
            await sqlConnection.OpenAsync();
            string Query = "Update Employee set " +
                "EmpFName=@EmpFName,EmpLName=@EmpLName,Passport=@Passport," +
                "DateTime=@DateTime,Gender=@Gender,Salary=@Salary,EmployedDate=@EmployedDate,StrAddress=@StrAddress," +
                "Apt=@Apt,City=@City,Region=@Region,ZipCode=@ZipCode,PhoneNo=@PhoneNo,Email=@Email,EmpType=@EmpType,Department=@Department" +
                " wherer id =@EmpId) ";

            int result = await sqlConnection.ExecuteAsync(Query, entity);
            return result > 0;

        }
        catch (Exception ex)
        {
            await Console.Out.WriteLineAsync(ex.Message);
            return false;
        }
        finally
        {
            await sqlConnection.CloseAsync() ;
        }
    }
}














