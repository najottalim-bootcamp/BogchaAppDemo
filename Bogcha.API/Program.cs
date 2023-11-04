using Bogcha.DataAccess.Repositories.WithdrawalRepositories;
using Bogcha.Domain.Entities;

var builder = WebApplication.CreateBuilder(args);
var repo = new WithdrawalRepository(builder.Configuration.GetConnectionString("DefaultConnection"));

var with = new Withdrawal()
{
    Id = 1,
    Amount = 900,
    DatePaid = new DateTime(2022, 6, 11),
    Expense = "Sanitary",
    WithDrawnBy = "EMP11"
};

var res = await repo.UpdateAsync(with);
Console.WriteLine(res);

// Add services to the container.

//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

app.Run();
