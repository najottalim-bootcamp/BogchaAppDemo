namespace Bogcha.DataAccess.Repositories;

public class Database
{
    protected readonly SqlConnection sqlConnection;

    public Database(string connectionString)
    {
        sqlConnection = new SqlConnection(connectionString);
    }
}
