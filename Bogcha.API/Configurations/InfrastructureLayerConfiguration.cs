namespace Bogcha.API.Configurations;

public static class InfrastructureLayerConfiguration
{
    public static void ConfigureInfrastructure(this WebApplicationBuilder builder)
    {
        //adding services
        builder.Services.AddScoped<IAccident_RecordsService, Accident_RecordsService>();
        builder.Services.AddScoped<IRevenueService, RevenueService>();
        builder.Services.AddScoped<IWithdrawalService, WithdrawalService>();
        builder.Services.AddScoped<IMealPlanService, MealPlanService>();
        builder.Services.AddScoped<IMenuManagementService, MenuManagementService>();
        builder.Services.AddScoped<IEmployeeService, EmployeeService>();

        builder.Services.AddScoped<IAttendanceService, AttendanceService>();
        builder.Services.AddScoped<IActivityManagementService, ActivityManagementService>();

        builder.Services.AddScoped<IParentsService, ParentsService>();

        builder.Services.AddScoped<IStudentService, StudentService>();

        builder.Services.AddScoped<IAssessmentRecKGService, AssessmentRecKGService>();
        builder.Services.AddScoped<IAssessmentRecNurseryService, AssessmentRecNurseryService>();
        builder.Services.AddScoped<IAssessmentRecPreKService, AssessmentRecPreKService>();


    }
}
