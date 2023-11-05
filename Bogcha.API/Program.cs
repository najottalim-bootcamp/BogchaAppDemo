var builder = WebApplication.CreateBuilder(args);

//Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

//adding repositories
builder.Services.AddScoped<IRevenueRepository>(x => new RevenueRepository(connectionString));
builder.Services.AddScoped<IWithdrawalRepository>(x => new WithdrawalRepository(connectionString));
builder.Services.AddScoped<IAccident_RecordsRepository>(x=> new Accident_RecordsRepository(connectionString));
builder.Services.AddScoped<IEmployeeRepository>(x => new EmployeeRepository(connectionString));
builder.Services.AddScoped<IMealPlanRepository>(x => new MealPlanRepository(connectionString));
builder.Services.AddScoped<IMenuManagementRepository>(x => new MenuManagementRepository(connectionString));




//adding services
builder.Services.AddScoped<IAccident_RecordsService, Accident_RecordsService>();
builder.Services.AddScoped<IRevenueService, RevenueService>();
builder.Services.AddScoped<IWithdrawalService, WithdrawalService>();
builder.Services.AddScoped<IMealPlanService, MealPlanService>();
builder.Services.AddScoped<IMenuManagementService, MenuManagementService>();
builder.Services.AddScoped<IMenuManagementRepository, MenuManagementService>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
