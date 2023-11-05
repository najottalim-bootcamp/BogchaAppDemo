namespace Bogcha.DataAccess.Repositories.MenuManagementRepositories;

public class MenuManagementRepository : Database, IMenuManagementRepository
{
    public MenuManagementRepository(string connectionString) : base(connectionString) { }

}
