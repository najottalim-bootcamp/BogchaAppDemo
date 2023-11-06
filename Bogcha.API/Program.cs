using Bogcha.DataAccess.Repositories.AssessmentRecKGRepositories;
using Bogcha.DataAccess.Repositories.AssessmentRecNurseryRepositories;
using Bogcha.DataAccess.Repositories.AssessmentRecPreKRepositories;
using Bogcha.Services.Services.AssessmentRecKGServices;
using Bogcha.Services.Services.AssessmentRecNurseryServices;
using Bogcha.Services.Services.AssessmentRecPreKServices;
using Bogcha.Services.Services.RevenueServices;

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

builder.Services.AddScoped<IAssessmentRecKGRepository>(x => new AssessmentRecKGRepository(connectionString));
builder.Services.AddScoped<IAssessmentRecNurseryRepository>(x => new AssessmentRecNurseryRepository(connectionString));
builder.Services.AddScoped<IAssessmentRecPreKRepository>(x => new AssessmentRecPreKRepository(connectionString));

//adding services
builder.Services.AddScoped<IRevenueService, RevenueService>();
builder.Services.AddScoped<IAssessmentRecKGService, AssessmentRecKGService>();
builder.Services.AddScoped<IAssessmentRecNurseryService, AssessmentRecNurseryService>();
builder.Services.AddScoped<IAssessmentRecPreKService, AssessmentRecPreKService>();

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
