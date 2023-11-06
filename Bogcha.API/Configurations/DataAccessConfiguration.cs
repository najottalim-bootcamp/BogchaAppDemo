
namespace Bogcha.API.Configurations;

public static class DataAccessConfiguration
{
    public static void ConfigureDataAccess(this WebApplicationBuilder builder)
    {
        string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

        //adding repositories
        builder.Services.AddScoped<IRevenueRepository>(x => new RevenueRepository(connectionString));
        builder.Services.AddScoped<IWithdrawalRepository>(x => new WithdrawalRepository(connectionString));
        builder.Services.AddScoped<IAccident_RecordsRepository>(x => new Accident_RecordsRepository(connectionString));
        builder.Services.AddScoped<IEmployeeRepository>(x => new EmployeeRepository(connectionString));
        builder.Services.AddScoped<IMealPlanRepository>(x => new MealPlanRepository(connectionString));
        builder.Services.AddScoped<IMenuManagementRepository>(x => new MenuManagementRepository(connectionString));
        builder.Services.AddScoped<IAttendanceRepository>(x => new AttendanceRepository(connectionString));
        builder.Services.AddScoped<IActivityManagementRepository>(x => new ActivityManagementRepository(connectionString));
    }
}
