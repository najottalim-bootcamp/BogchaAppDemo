using System.Data.SqlClient;

namespace Bogcha.DataAccess.Repositories;

public class Database
{
    protected readonly SqlConnection sqlConnection;

    public Database(string connectionString)
    {
        this.sqlConnection = new SqlConnection(connectionString);
    }
}
